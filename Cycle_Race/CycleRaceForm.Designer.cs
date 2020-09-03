namespace Cycle_Race
{
    partial class CycleRaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CycleRaceForm));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.CycleBlack = new System.Windows.Forms.PictureBox();
            this.CycleBlue = new System.Windows.Forms.PictureBox();
            this.CycleRed = new System.Windows.Forms.PictureBox();
            this.CycleYellow = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KumarBet = new System.Windows.Forms.Label();
            this.SinghBet = new System.Windows.Forms.Label();
            this.KaurBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.CycleNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.KumarButton = new System.Windows.Forms.RadioButton();
            this.SinghButton = new System.Windows.Forms.RadioButton();
            this.KaurButton = new System.Windows.Forms.RadioButton();
            this.HigherBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleYellow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CycleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 16);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1218, 542);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            this.racetrack.Click += new System.EventHandler(this.racetrack_Click);
            // 
            // CycleBlack
            // 
            this.CycleBlack.Image = ((System.Drawing.Image)(resources.GetObject("CycleBlack.Image")));
            this.CycleBlack.Location = new System.Drawing.Point(52, 57);
            this.CycleBlack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycleBlack.Name = "CycleBlack";
            this.CycleBlack.Size = new System.Drawing.Size(130, 95);
            this.CycleBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CycleBlack.TabIndex = 1;
            this.CycleBlack.TabStop = false;
            // 
            // CycleBlue
            // 
            this.CycleBlue.ErrorImage = null;
            this.CycleBlue.Image = ((System.Drawing.Image)(resources.GetObject("CycleBlue.Image")));
            this.CycleBlue.InitialImage = ((System.Drawing.Image)(resources.GetObject("CycleBlue.InitialImage")));
            this.CycleBlue.Location = new System.Drawing.Point(52, 173);
            this.CycleBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycleBlue.Name = "CycleBlue";
            this.CycleBlue.Size = new System.Drawing.Size(136, 91);
            this.CycleBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CycleBlue.TabIndex = 2;
            this.CycleBlue.TabStop = false;
            this.CycleBlue.Click += new System.EventHandler(this.CycleBlue_Click);
            // 
            // CycleRed
            // 
            this.CycleRed.Image = ((System.Drawing.Image)(resources.GetObject("CycleRed.Image")));
            this.CycleRed.Location = new System.Drawing.Point(52, 283);
            this.CycleRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycleRed.Name = "CycleRed";
            this.CycleRed.Size = new System.Drawing.Size(136, 92);
            this.CycleRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CycleRed.TabIndex = 3;
            this.CycleRed.TabStop = false;
            // 
            // CycleYellow
            // 
            this.CycleYellow.Image = ((System.Drawing.Image)(resources.GetObject("CycleYellow.Image")));
            this.CycleYellow.Location = new System.Drawing.Point(52, 395);
            this.CycleYellow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycleYellow.Name = "CycleYellow";
            this.CycleYellow.Size = new System.Drawing.Size(136, 88);
            this.CycleYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CycleYellow.TabIndex = 4;
            this.CycleYellow.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.KumarBet);
            this.groupBox1.Controls.Add(this.SinghBet);
            this.groupBox1.Controls.Add(this.KaurBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.CycleNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.KumarButton);
            this.groupBox1.Controls.Add(this.SinghButton);
            this.groupBox1.Controls.Add(this.KaurButton);
            this.groupBox1.Controls.Add(this.HigherBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 569);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1203, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet ";
            // 
            // KumarBet
            // 
            this.KumarBet.BackColor = System.Drawing.SystemColors.Info;
            this.KumarBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KumarBet.Location = new System.Drawing.Point(514, 149);
            this.KumarBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KumarBet.Name = "KumarBet";
            this.KumarBet.Size = new System.Drawing.Size(434, 24);
            this.KumarBet.TabIndex = 13;
            this.KumarBet.Text = "label6";
            // 
            // SinghBet
            // 
            this.SinghBet.BackColor = System.Drawing.SystemColors.Info;
            this.SinghBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SinghBet.Location = new System.Drawing.Point(514, 103);
            this.SinghBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SinghBet.Name = "SinghBet";
            this.SinghBet.Size = new System.Drawing.Size(434, 24);
            this.SinghBet.TabIndex = 12;
            this.SinghBet.Text = "label5";
            // 
            // KaurBet
            // 
            this.KaurBet.BackColor = System.Drawing.SystemColors.Info;
            this.KaurBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KaurBet.Location = new System.Drawing.Point(514, 55);
            this.KaurBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KaurBet.Name = "KaurBet";
            this.KaurBet.Size = new System.Drawing.Size(434, 24);
            this.KaurBet.TabIndex = 11;
            this.KaurBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.White;
            this.race.Location = new System.Drawing.Point(1019, 53);
            this.race.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(128, 89);
            this.race.TabIndex = 9;
            this.race.Text = "Begin Race";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // CycleNumber
            // 
            this.CycleNumber.Location = new System.Drawing.Point(151, 166);
            this.CycleNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CycleNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CycleNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CycleNumber.Name = "CycleNumber";
            this.CycleNumber.Size = new System.Drawing.Size(96, 28);
            this.CycleNumber.TabIndex = 8;
            this.CycleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cycle number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(22, 166);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(94, 28);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderSize = 5;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.ForeColor = System.Drawing.Color.White;
            this.Bets.Location = new System.Drawing.Point(292, 151);
            this.Bets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(184, 55);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Make A Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // KumarButton
            // 
            this.KumarButton.AutoSize = true;
            this.KumarButton.Checked = true;
            this.KumarButton.Location = new System.Drawing.Point(213, 68);
            this.KumarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KumarButton.Name = "KumarButton";
            this.KumarButton.Size = new System.Drawing.Size(92, 26);
            this.KumarButton.TabIndex = 3;
            this.KumarButton.TabStop = true;
            this.KumarButton.Text = "Kumar";
            this.KumarButton.UseVisualStyleBackColor = true;
            this.KumarButton.CheckedChanged += new System.EventHandler(this.KumarButton_CheckedChanged);
            // 
            // SinghButton
            // 
            this.SinghButton.AutoSize = true;
            this.SinghButton.Location = new System.Drawing.Point(103, 68);
            this.SinghButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SinghButton.Name = "SinghButton";
            this.SinghButton.Size = new System.Drawing.Size(86, 26);
            this.SinghButton.TabIndex = 2;
            this.SinghButton.Text = "Singh";
            this.SinghButton.UseVisualStyleBackColor = true;
            this.SinghButton.CheckedChanged += new System.EventHandler(this.SinghButton_CheckedChanged);
            // 
            // KaurButton
            // 
            this.KaurButton.AutoSize = true;
            this.KaurButton.Location = new System.Drawing.Point(14, 68);
            this.KaurButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KaurButton.Name = "KaurButton";
            this.KaurButton.Size = new System.Drawing.Size(77, 26);
            this.KaurButton.TabIndex = 1;
            this.KaurButton.Text = "Kaur";
            this.KaurButton.UseVisualStyleBackColor = true;
            this.KaurButton.CheckedChanged += new System.EventHandler(this.KaurButton_CheckedChanged);
            // 
            // HigherBet
            // 
            this.HigherBet.AutoSize = true;
            this.HigherBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HigherBet.Location = new System.Drawing.Point(17, 38);
            this.HigherBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HigherBet.Name = "HigherBet";
            this.HigherBet.Size = new System.Drawing.Size(111, 25);
            this.HigherBet.TabIndex = 0;
            this.HigherBet.Text = "Higher bet";
            // 
            // CycleRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 826);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CycleYellow);
            this.Controls.Add(this.CycleRed);
            this.Controls.Add(this.CycleBlue);
            this.Controls.Add(this.CycleBlack);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CycleRaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cycle Race";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleYellow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CycleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox CycleBlack;
        private System.Windows.Forms.PictureBox CycleBlue;
        private System.Windows.Forms.PictureBox CycleRed;
        private System.Windows.Forms.PictureBox CycleYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton KumarButton;
        private System.Windows.Forms.RadioButton SinghButton;
        private System.Windows.Forms.RadioButton KaurButton;
        private System.Windows.Forms.Label HigherBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown CycleNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KaurBet;
        private System.Windows.Forms.Label KumarBet;
        private System.Windows.Forms.Label SinghBet;
    }
}
