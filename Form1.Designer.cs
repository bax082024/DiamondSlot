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
            labelJackpot = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox11 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox14 = new PictureBox();
            btnPaytable = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.LemonChiffon;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
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
            pictureBox2.Location = new Point(166, 3);
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
            pictureBox3.Location = new Point(329, 3);
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(645, 616);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Credits: 100";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(217, 593);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Bet: 5";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(957, 616);
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
            button1.Location = new Point(435, 613);
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
            btnAddBet.Location = new Point(253, 616);
            btnAddBet.Name = "btnAddBet";
            btnAddBet.Size = new Size(15, 15);
            btnAddBet.TabIndex = 7;
            btnAddBet.UseVisualStyleBackColor = false;
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
            btnDecreaseBet.Location = new Point(217, 616);
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
            // labelJackpot
            // 
            labelJackpot.Anchor = AnchorStyles.None;
            labelJackpot.AutoSize = true;
            labelJackpot.BackColor = Color.Black;
            labelJackpot.Font = new Font("Algerian", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJackpot.ForeColor = Color.Gold;
            labelJackpot.Location = new Point(391, 58);
            labelJackpot.Name = "labelJackpot";
            labelJackpot.Size = new Size(251, 39);
            labelJackpot.TabIndex = 9;
            labelJackpot.Text = "Jackpot 500";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnPaytable);
            panel1.Controls.Add(labelJackpot);
            panel1.Controls.Add(btnDecreaseBet);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddBet);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 673);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox15);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox14);
            panel2.Location = new Point(116, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 444);
            panel2.TabIndex = 13;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.None;
            pictureBox11.BackColor = Color.LemonChiffon;
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.Location = new Point(654, 299);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(150, 142);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 24;
            pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.None;
            pictureBox13.BackColor = Color.LemonChiffon;
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            pictureBox13.Location = new Point(3, 299);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(150, 142);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 20;
            pictureBox13.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.BackColor = Color.LemonChiffon;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(491, 151);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(150, 142);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.None;
            pictureBox10.BackColor = Color.LemonChiffon;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.Location = new Point(329, 151);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(150, 142);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 17;
            pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.None;
            pictureBox12.BackColor = Color.LemonChiffon;
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            pictureBox12.Location = new Point(491, 299);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(150, 142);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 23;
            pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox9.BackColor = Color.LemonChiffon;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Location = new Point(166, 151);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(150, 142);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackColor = Color.LemonChiffon;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(654, 151);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 142);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackColor = Color.LemonChiffon;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(3, 151);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(150, 142);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.LemonChiffon;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(654, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 142);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.None;
            pictureBox15.BackColor = Color.LemonChiffon;
            pictureBox15.BorderStyle = BorderStyle.FixedSingle;
            pictureBox15.Location = new Point(329, 299);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(150, 142);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 22;
            pictureBox15.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.LemonChiffon;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(491, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 142);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.None;
            pictureBox14.BackColor = Color.LemonChiffon;
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.Location = new Point(166, 299);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(150, 142);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 21;
            pictureBox14.TabStop = false;
            // 
            // btnPaytable
            // 
            btnPaytable.Anchor = AnchorStyles.None;
            btnPaytable.BackColor = Color.SeaGreen;
            btnPaytable.FlatStyle = FlatStyle.Flat;
            btnPaytable.Location = new Point(812, 593);
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
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1052, 673);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Jackpot 500";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
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
        private Label labelJackpot;
        private Panel panel1;
        private Button btnPaytable;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel2;
    }
}
