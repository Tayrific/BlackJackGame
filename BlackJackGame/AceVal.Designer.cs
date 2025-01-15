namespace BlackJackGame
{
    partial class AceVal
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
            btn11 = new Button();
            btn1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn11
            // 
            btn11.BackColor = Color.Lavender;
            btn11.FlatAppearance.BorderSize = 0;
            btn11.ForeColor = Color.DarkSlateBlue;
            btn11.Location = new Point(174, 81);
            btn11.Name = "btn11";
            btn11.Size = new Size(75, 23);
            btn11.TabIndex = 0;
            btn11.Text = "11";
            btn11.UseVisualStyleBackColor = false;
            btn11.Click += btn11_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Lavender;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.ForeColor = Color.DarkSlateBlue;
            btn1.Location = new Point(59, 81);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(2, 24);
            label1.Name = "label1";
            label1.Size = new Size(307, 42);
            label1.TabIndex = 2;
            label1.Text = "You drew an Ace! \r\nWould you like it to be worth 1 or 11?\",";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // AceVal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(314, 121);
            Controls.Add(label1);
            Controls.Add(btn1);
            Controls.Add(btn11);
            ForeColor = Color.Indigo;
            Name = "AceVal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AceVal";
            Load += AceVal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn11;
        private Button btn1;
        private Label label1;
    }
}