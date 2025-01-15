namespace BlackJackGame
{
    partial class SinglePlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayerForm));
            playerCardsLabel = new Label();
            playerScoreLabel = new Label();
            dealerCardsLabel = new Label();
            dealerScoreLabel = new Label();
            HitButton = new Button();
            StandButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            winLabel = new Label();
            lostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playerCardsLabel
            // 
            playerCardsLabel.AutoSize = true;
            playerCardsLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            playerCardsLabel.ForeColor = Color.CadetBlue;
            playerCardsLabel.Location = new Point(45, 237);
            playerCardsLabel.Name = "playerCardsLabel";
            playerCardsLabel.Size = new Size(88, 22);
            playerCardsLabel.TabIndex = 1;
            playerCardsLabel.Text = "Your Hand";
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.AutoSize = true;
            playerScoreLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            playerScoreLabel.ForeColor = Color.CadetBlue;
            playerScoreLabel.Location = new Point(45, 259);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(54, 22);
            playerScoreLabel.TabIndex = 2;
            playerScoreLabel.Text = "label1";
            // 
            // dealerCardsLabel
            // 
            dealerCardsLabel.AutoSize = true;
            dealerCardsLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            dealerCardsLabel.ForeColor = Color.CadetBlue;
            dealerCardsLabel.Location = new Point(45, 21);
            dealerCardsLabel.Name = "dealerCardsLabel";
            dealerCardsLabel.Size = new Size(108, 22);
            dealerCardsLabel.TabIndex = 3;
            dealerCardsLabel.Text = "Dealers Hand";
            // 
            // dealerScoreLabel
            // 
            dealerScoreLabel.AutoSize = true;
            dealerScoreLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            dealerScoreLabel.ForeColor = Color.CadetBlue;
            dealerScoreLabel.Location = new Point(45, 43);
            dealerScoreLabel.Name = "dealerScoreLabel";
            dealerScoreLabel.Size = new Size(59, 22);
            dealerScoreLabel.TabIndex = 4;
            dealerScoreLabel.Text = "Score:";
            // 
            // HitButton
            // 
            HitButton.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
            HitButton.Location = new Point(713, 152);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(88, 44);
            HitButton.TabIndex = 5;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = true;
            HitButton.Click += HitButton_Click;
            // 
            // StandButton
            // 
            StandButton.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
            StandButton.Location = new Point(757, 87);
            StandButton.Name = "StandButton";
            StandButton.Size = new Size(88, 50);
            StandButton.TabIndex = 6;
            StandButton.Text = "Stand";
            StandButton.UseVisualStyleBackColor = true;
            StandButton.Click += StandButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(757, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 115);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(726, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // winLabel
            // 
            winLabel.AutoSize = true;
            winLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            winLabel.ForeColor = Color.CadetBlue;
            winLabel.Location = new Point(575, 520);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(67, 22);
            winLabel.TabIndex = 8;
            winLabel.Text = "WINS: 0";
            // 
            // lostLabel
            // 
            lostLabel.AutoSize = true;
            lostLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lostLabel.ForeColor = Color.CadetBlue;
            lostLabel.Location = new Point(726, 520);
            lostLabel.Name = "lostLabel";
            lostLabel.Size = new Size(66, 22);
            lostLabel.TabIndex = 9;
            lostLabel.Text = "LOST: 0";
            // 
            // SinglePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(884, 561);
            Controls.Add(lostLabel);
            Controls.Add(winLabel);
            Controls.Add(StandButton);
            Controls.Add(HitButton);
            Controls.Add(dealerScoreLabel);
            Controls.Add(dealerCardsLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(playerCardsLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "SinglePlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinglePlayerForm";
            Load += SinglePlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label playerCardsLabel;
        private Label playerScoreLabel;
        private Label dealerCardsLabel;
        private Label dealerScoreLabel;
        private Button HitButton;
        private Button StandButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label winLabel;
        private Label lostLabel;
    }
}