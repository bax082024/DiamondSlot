using WMPLib;

namespace Slot777
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new();
        private readonly Dictionary<int, Image> imageCache = new();

        // Declare each item
        private int p1, p2, p3;

        // Declare total, bet, and credits
        private long credits = 100;
        private long total = 0;
        private const int MaxBet = 10;
        private const int MinBet = 1;
        private int bet = 1;
        private int spinCount = 0;
        private long jackpot = 500;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize Timer
            spinTimer.Interval = 100; // Adjust spin interval as desired (milliseconds)
            spinTimer.Tick += spinTimer_Tick; // Attach the Tick event

            // Preload images into a cache for better performance
            LoadImages();

            // Initialize UI
            pictureBox1.Image = imageCache[1];
            pictureBox2.Image = imageCache[2];
            pictureBox3.Image = imageCache[3];
            UpdateUI();
        }

        private void LoadImages()
        {
            int numberOfImages = 5; // Update this to the total number of images
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
            // Generate random numbers for each reel
            int maxImageIndex = imageCache.Count;
            p1 = random.Next(1, maxImageIndex + 1);
            p2 = random.Next(1, maxImageIndex + 1);
            p3 = random.Next(1, maxImageIndex + 1);

            // Assign corresponding images
            pictureBox1.Image = imageCache[p1];
            pictureBox2.Image = imageCache[p2];
            pictureBox3.Image = imageCache[p3];
        }

        private void CalculateWin()
        {
            total = 0;

            // Check for cherries
            if (p1 == 3 && p2 != 3 && p3 != 3) // 1 cherry on Reel 1
            {
                total += bet; // Bet returned
            }
            else if (p1 == 3 && p2 == 3 && p3 != 3) // 2 cherries on Reel 1 and Reel 2
            {
                total += bet + (2 * bet); // Bet returned + 2 times bet
            }
            else if (p1 == 3 && p2 == 3 && p3 == 3) // 3 cherries on all reels
            {
                total += 15 * bet; // 15 times the bet
            }

            // Regular paytable: All symbols must match on all 3 reels
            else if (p1 == 1 && p2 == 1 && p3 == 1) // Example: Grapes (symbol 1)
            {
                total += 20 * bet; // 20 times the bet
            }
            else if (p1 == 2 && p2 == 2 && p3 == 2) // Example: Bells (symbol 2)
            {
                total += 30 * bet; // 30 times the bet
            }
            else if (p1 == 4 && p2 == 4 && p3 == 4) // Example: Diamonds (symbol 4)
            {
                total += 50 * bet; // 50 times the bet
            }
            else if (p1 == 5 && p2 == 5 && p3 == 5) // Jackpot symbols (symbol 5)
            {
                total += 100 * bet; // Jackpot prize scaled with bet
                MessageBox.Show($"JACKPOT! You won {total} credits!", "Jackpot!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Update credits
            credits += total;
        }




        private void UpdateUI()
        {
            label1.Text = $"Credits: {credits}";
            label2.Text = $"Bet: {bet}";
            label3.Text = $"Win: {total}";
        }




        private void button1_Click(object sender, EventArgs e)
        {
            PlaySound();

            if (bet > credits)
            {
                MessageBox.Show("Not enough credits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (credits >= bet)
            {
                // Deduct the bet
                credits -= bet;



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
            if (bet < MaxBet && bet < credits)
            {
                bet += 1; // Increase the bet
                UpdateUI(); // Refresh UI to show the updated bet
            }
            else if (bet >= MaxBet)
            {
                MessageBox.Show($"The maximum bet is {MaxBet}!", "Max Bet Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bet cannot exceed your available credits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void spinTimer_Tick(object sender, EventArgs e)
        {


            // Spin the reels by assigning random images
            pictureBox1.Image = imageCache[random.Next(1, imageCache.Count + 1)];
            pictureBox2.Image = imageCache[random.Next(1, imageCache.Count + 1)];
            pictureBox3.Image = imageCache[random.Next(1, imageCache.Count + 1)];

            spinCount++;

            // Stop spinning after a certain number of spins
            if (spinCount >= 20) // Adjust for the number of spins
            {
                spinTimer.Stop();
                spinCount = 0;

                // Calculate the final result
                SpinReels(); // Final spin to set the outcome
                CalculateWin();
                UpdateUI();

                // Game Over Check
                if (credits <= 0)
                {
                    MessageBox.Show("Game Over! No more credits.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    credits = 100; // Reset credits
                    UpdateUI();
                }
            }
        }

        private void PlaySound()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "Sound/spin.mp3"; // Provide the path to your MP3 file
            player.controls.play();
        }

        // connect button to paytable form
        private void btnPaytable_Click(object sender, EventArgs e)
        {
            // Create an instance of the PaytableForm
            PaytableForm paytableForm = new PaytableForm();

            // Show the PaytableForm as a dialog
            paytableForm.ShowDialog();
        }
    }
}
