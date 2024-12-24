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
        private int bet = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            for (int i = 1; i <= 3; i++)
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
            p1 = random.Next(1, 4);
            p2 = random.Next(1, 4);
            p3 = random.Next(1, 4);

            // Assign corresponding images
            pictureBox1.Image = imageCache[p1];
            pictureBox2.Image = imageCache[p2];
            pictureBox3.Image = imageCache[p3];
        }

        private void CalculateWin()
        {
            total = 0;

            // Basic paytable logic
            if (p1 == 3) total += 5;
            if (p1 == 2 && p2 == 2) total += 10;
            if (p1 == 3 && p2 == 3) total += 10;
            if (p1 == 1 && p2 == 1 && p3 == 1) total += 20;
            if (p1 == 2 && p2 == 2 && p3 == 2) total += 30;
            if (p1 == 3 && p2 == 3 && p3 == 3) total += 50;

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
            if (credits >= bet)
            {
                // Deduct the bet
                credits -= bet;

                // Spin the reels
                SpinReels();

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
            if (bet < credits)
            {
                bet += 1; // Increse bet 
                UpdateUI() ; // refresh ui to show ne bet
            }
            else
            {
                MessageBox.Show("Bet cannot exceed your available credits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
        }

        private void btnDecreaseBet_Click(object sender, EventArgs e)
        {

        }
    }
}
