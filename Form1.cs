using WMPLib;

namespace Slot777
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new();
        private readonly Dictionary<int, Image> imageCache = new();
        private List<PictureBox> reels = new List<PictureBox>();

        private long credits = 100;
        private long total = 0;
        private const int MaxBet = 10;
        private const int MinBet = 1;
        private int bet = 1;
        private int spinCount = 0;
        private long jackpot = 500;

        // Lines and active line tracking
        private bool[] activeLines = new bool[5]; // 5 lines available
        private int activeLineCount = 1; // Minimum 1 active line

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spinTimer.Interval = 100;
            spinTimer.Tick += spinTimer_Tick;

            LoadImages();

            reels.AddRange(new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15
            });

            for (int i = 0; i < reels.Count; i++)
            {
                reels[i].Image = imageCache[(i % imageCache.Count) + 1];
            }

            // Initialize active lines (default: only Line 1 is active)
            activeLines[0] = true;

            UpdateLineLabels();
            UpdateUI();
        }

        private void LoadImages()
        {
            int numberOfImages = 10;
            for (int i = 1; i <= numberOfImages; i++)
            {
                string fileName = $"{i}.png";
                if (File.Exists(fileName))
                {
                    imageCache[i] = Image.FromFile(fileName);
                }
                else
                {
                    MessageBox.Show($"Image file not found: {fileName}");
                }
            }
        }

        private void SpinReels()
        {
            int maxImageIndex = imageCache.Count;

            for (int i = 0; i < reels.Count; i++)
            {
                int randomImage = random.Next(1, maxImageIndex + 1);
                reels[i].Image = imageCache[randomImage];
            }
        }

        private void CalculateWin()
        {
            total = 0;

            // Define the lines
            int[][] lines = new int[][]
            {
                new int[] { 0, 1, 2, 3, 4 }, // Top row
                new int[] { 5, 6, 7, 8, 9 }, // Middle row
                new int[] { 10, 11, 12, 13, 14 }, // Bottom row
                new int[] { 0, 6, 12, 8, 4 }, // Diagonal top-left to bottom-right
                new int[] { 10, 6, 2, 8, 14 } // Diagonal bottom-left to top-right
            };

            foreach (var (line, isActive) in lines.Zip(activeLines, (line, isActive) => (line, isActive)))
            {
                if (!isActive) continue; // Skip inactive lines

                int firstSymbol = GetSymbolIndex(line[0]);
                bool isWinLine = true;

                foreach (int index in line)
                {
                    if (GetSymbolIndex(index) != firstSymbol)
                    {
                        isWinLine = false;
                        break;
                    }
                }

                if (isWinLine)
                {
                    // Standard payouts
                    if (firstSymbol == 1) total += 20 * bet; // Icon 1
                    else if (firstSymbol == 3) total += 15 * bet; // Icon 3
                    else if (firstSymbol == 4) total += 50 * bet; // Icon 4
                    else if (firstSymbol == 5) // Jackpot
                    {
                        total += 100 * bet;
                        MessageBox.Show($"JACKPOT! You won {total} credits!", "Jackpot!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            // Special payouts for 2.png (icon 2)
            if (GetSymbolIndex(0) == 2) // Reel 1 contains the special symbol
            {
                int specialCount = 1; // Start with Reel 1
                if (GetSymbolIndex(1) == 2) specialCount++; // Check Reel 2
                if (GetSymbolIndex(2) == 2) specialCount++; // Check Reel 3

                // Calculate payout based on special symbol count
                if (specialCount == 1)
                {
                    total += bet; // Bet returned
                }
                else if (specialCount == 2)
                {
                    total += bet + (2 * bet); // Bet + 2 times bet
                }
                else if (specialCount == 3)
                {
                    total += bet + (4 * bet); // Bet + 4 times bet
                }
            }

            credits += total; // Update credits
        }



        private int GetSymbolIndex(int reelIndex)
        {
            foreach (var kvp in imageCache)
            {
                if (reels[reelIndex].Image == kvp.Value)
                {
                    return kvp.Key;
                }
            }
            return -1;
        }

        private void UpdateUI()
        {
            label1.Text = $"Credits: {credits}";
            label2.Text = $"Bet: {bet}";
            label3.Text = $"Win: {total}";
            labelJackpot.Text = $"Jackpot: {jackpot}";
            lblActiveLines.Text = $"Active Lines: {activeLineCount}";
        }

        private void UpdateLineLabels()
        {
            Label[] leftLabels = { lblLine1, lblLine2, lblLine3, lblLine4, lblLine5 };
            Label[] rightLabels = { lblLine6, lblLine7, lblLine8, lblLine9, lblLine10 };

            for (int i = 0; i < activeLines.Length; i++)
            {
                if (activeLines[i])
                {
                    leftLabels[i].ForeColor = Color.White; // Active lines in white
                    rightLabels[i].ForeColor = Color.White;
                }
                else
                {
                    leftLabels[i].ForeColor = Color.Gray; // Inactive lines in gray
                    rightLabels[i].ForeColor = Color.Gray;
                }

                // Adjust font size and alignment
                leftLabels[i].Font = new Font("Arial", 12, FontStyle.Bold); // Bigger and bolder
                rightLabels[i].Font = new Font("Arial", 12, FontStyle.Bold);

                // Adjust label size
                leftLabels[i].AutoSize = true;
                rightLabels[i].AutoSize = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PlaySound();

            int spinCost = activeLineCount * bet; // Total cost of the spin

            if (spinCost > credits)
            {
                MessageBox.Show("Not enough credits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (credits >= spinCost)
            {
                // Deduct the total cost of the spin
                credits -= spinCost;

                // Spin the reels
                SpinReels();

                // Start the spin animation
                spinCount = 0; // Reset the spin count
                spinTimer.Start();

                // Calculate win
                CalculateWin();

                // Update the UI
                UpdateUI();

                // Game Over Check
                if (credits <= 0)
                {
                    MessageBox.Show("Game Over! No more credits.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    credits = 100; // Reset credits
                    UpdateUI();
                }
            }
            else
            {
                MessageBox.Show("Not enough credits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            if (bet < 3 && (activeLineCount * (bet + 1)) <= credits) // Limit max bet to 3 and ensure enough credits
            {
                bet += 1; // Increase the bet
                UpdateUI(); // Refresh UI to show the updated bet
            }
            else if (bet >= 3)
            {
                MessageBox.Show("Maximum bet is 3!", "Max Bet Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not enough credits for this bet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecreaseBet_Click(object sender, EventArgs e)
        {
            if (bet > MinBet)
            {
                bet -= 1;
                UpdateUI();
            }
            else
            {
                MessageBox.Show($"The minimum bet is {MinBet}!", "Min Bet Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void spinTimer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i < reels.Count; i++)
            {
                reels[i].Image = imageCache[random.Next(1, imageCache.Count + 1)];
            }

            spinCount++;

            if (spinCount >= 20)
            {
                spinTimer.Stop();
                spinCount = 0;

                SpinReels();
                CalculateWin();
                UpdateUI();

                if (credits <= 0)
                {
                    MessageBox.Show("Game Over! No more credits.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    credits = 100;
                    UpdateUI();
                }
            }
        }

        private void PlaySound()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "Sound/spin.mp3";
            player.controls.play();
        }

        private void btnPaytable_Click(object sender, EventArgs e)
        {
            PaytableForm paytableForm = new PaytableForm();
            paytableForm.ShowDialog();
        }

        private void btnIncreaseLines_Click(object sender, EventArgs e)
        {
            if (activeLineCount < activeLines.Length)
            {
                activeLineCount++;
                activeLines[activeLineCount - 1] = true;
                UpdateLineLabels();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("All lines are already active!", "Max Lines", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecreaseLines_Click(object sender, EventArgs e)
        {
            if (activeLineCount > 1)
            {
                activeLines[activeLineCount - 1] = false;
                activeLineCount--;
                UpdateLineLabels();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("At least one line must be active!", "Min Lines", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
