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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnAddBet = new Button();
            btnDecreaseBet = new Button();
            spinTimer = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            btnPaytable = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.LemonChiffon;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(38, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.LemonChiffon;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(201, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.LemonChiffon;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(364, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(99, 305);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Credits: 100";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(69, 381);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Bet: 5";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(411, 305);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Win: 0";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LawnGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(220, 365);
            button1.Name = "button1";
            button1.Size = new Size(131, 43);
            button1.TabIndex = 6;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddBet
            // 
            btnAddBet.Anchor = AnchorStyles.None;
            btnAddBet.BackColor = Color.DarkOliveGreen;
            btnAddBet.BackgroundImage = Properties.Resources.plus;
            btnAddBet.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBet.FlatStyle = FlatStyle.Flat;
            btnAddBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddBet.ImageAlign = ContentAlignment.TopLeft;
            btnAddBet.Location = new Point(105, 404);
            btnAddBet.Name = "btnAddBet";
            btnAddBet.Size = new Size(15, 15);
            btnAddBet.TabIndex = 7;
            btnAddBet.UseVisualStyleBackColor = false;
            btnAddBet.Click += btnAddBet_Click;
            // 
            // btnDecreaseBet
            // 
            btnDecreaseBet.Anchor = AnchorStyles.None;
            btnDecreaseBet.BackColor = Color.DarkOliveGreen;
            btnDecreaseBet.BackgroundImage = Properties.Resources.minus;
            btnDecreaseBet.BackgroundImageLayout = ImageLayout.Stretch;
            btnDecreaseBet.FlatStyle = FlatStyle.Flat;
            btnDecreaseBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDecreaseBet.ImageAlign = ContentAlignment.TopLeft;
            btnDecreaseBet.Location = new Point(69, 404);
            btnDecreaseBet.Name = "btnDecreaseBet";
            btnDecreaseBet.Size = new Size(15, 15);
            btnDecreaseBet.TabIndex = 8;
            btnDecreaseBet.Text = "-";
            btnDecreaseBet.UseVisualStyleBackColor = false;
            btnDecreaseBet.Click += btnDecreaseBet_Click;
            // 
            // spinTimer
            // 
            spinTimer.Tick += spinTimer_Tick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Algerian", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(160, 40);
            label4.Name = "label4";
            label4.Size = new Size(251, 39);
            label4.TabIndex = 9;
            label4.Text = "Jackpot 500";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = Properties.Resources._5;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(85, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 50);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = Properties.Resources._5;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(436, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 50);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.BackgroundImage = Properties.Resources.bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnPaytable);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnDecreaseBet);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddBet);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(132, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 445);
            panel1.TabIndex = 12;
            // 
            // btnPaytable
            // 
            btnPaytable.BackColor = Color.SeaGreen;
            btnPaytable.FlatStyle = FlatStyle.Flat;
            btnPaytable.Location = new Point(486, 404);
            btnPaytable.Name = "btnPaytable";
            btnPaytable.Size = new Size(75, 22);
            btnPaytable.TabIndex = 12;
            btnPaytable.Text = "Paytable";
            btnPaytable.UseVisualStyleBackColor = false;
            btnPaytable.Click += btnPaytable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 564);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Timer spinTimer;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button btnPaytable;
    }
}
