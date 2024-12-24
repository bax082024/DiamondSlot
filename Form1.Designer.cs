namespace Slot777
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnAddBet = new Button();
            btnDecreaseBet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LemonChiffon;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(37, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LemonChiffon;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(186, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LemonChiffon;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(336, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Credits: 100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 205);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Bet: 5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(336, 20);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Win: 0";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(188, 189);
            button1.Name = "button1";
            button1.Size = new Size(131, 43);
            button1.TabIndex = 6;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddBet
            // 
            btnAddBet.BackColor = Color.Silver;
            btnAddBet.BackgroundImage = Properties.Resources.plus;
            btnAddBet.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBet.FlatStyle = FlatStyle.Flat;
            btnAddBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddBet.ImageAlign = ContentAlignment.TopLeft;
            btnAddBet.Location = new Point(62, 223);
            btnAddBet.Name = "btnAddBet";
            btnAddBet.Size = new Size(15, 15);
            btnAddBet.TabIndex = 7;
            btnAddBet.UseVisualStyleBackColor = false;
            btnAddBet.Click += btnAddBet_Click;
            // 
            // btnDecreaseBet
            // 
            btnDecreaseBet.BackColor = Color.Silver;
            btnDecreaseBet.BackgroundImage = Properties.Resources.minus;
            btnDecreaseBet.BackgroundImageLayout = ImageLayout.Stretch;
            btnDecreaseBet.FlatStyle = FlatStyle.Flat;
            btnDecreaseBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDecreaseBet.ImageAlign = ContentAlignment.TopLeft;
            btnDecreaseBet.Location = new Point(37, 223);
            btnDecreaseBet.Name = "btnDecreaseBet";
            btnDecreaseBet.Size = new Size(15, 15);
            btnDecreaseBet.TabIndex = 8;
            btnDecreaseBet.Text = "-";
            btnDecreaseBet.UseVisualStyleBackColor = false;
            btnDecreaseBet.Click += btnDecreaseBet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(509, 343);
            Controls.Add(btnDecreaseBet);
            Controls.Add(btnAddBet);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnAddBet;
        private Button btnDecreaseBet;
    }
}
