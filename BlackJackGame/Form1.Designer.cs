namespace BlackJackGame
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
            lblBlackJack = new Label();
            btnSinglePlayer = new Button();
            SuspendLayout();
            // 
            // lblBlackJack
            // 
            lblBlackJack.AutoSize = true;
            lblBlackJack.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlackJack.ForeColor = Color.Crimson;
            lblBlackJack.Location = new Point(148, 141);
            lblBlackJack.Name = "lblBlackJack";
            lblBlackJack.Size = new Size(589, 119);
            lblBlackJack.TabIndex = 0;
            lblBlackJack.Text = "BLACKJACK";
            // 
            // btnSinglePlayer
            // 
            btnSinglePlayer.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSinglePlayer.Location = new Point(309, 291);
            btnSinglePlayer.Name = "btnSinglePlayer";
            btnSinglePlayer.Size = new Size(270, 60);
            btnSinglePlayer.TabIndex = 1;
            btnSinglePlayer.Text = "PLAY";
            btnSinglePlayer.UseVisualStyleBackColor = true;
            btnSinglePlayer.Click += btnSinglePlayer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(884, 561);
            Controls.Add(btnSinglePlayer);
            Controls.Add(lblBlackJack);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBlackJack;
        private Button btnSinglePlayer;
    }
}
