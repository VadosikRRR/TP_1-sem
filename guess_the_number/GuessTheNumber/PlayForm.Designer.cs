namespace GuessTheNumber
{
    partial class PlayForm
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
            infoResultLabel = new Label();
            SuspendLayout();
            // 
            // infoResultLabel
            // 
            infoResultLabel.AutoSize = true;
            infoResultLabel.Location = new Point(455, 89);
            infoResultLabel.Name = "infoResultLabel";
            infoResultLabel.Size = new Size(50, 20);
            infoResultLabel.TabIndex = 0;
            infoResultLabel.Text = "";
            infoResultLabel.Font = new Font("Courier New", 20);
            infoResultLabel.AutoSize = true;
            infoResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoResultLabel.ForeColor = Color.LimeGreen;
            infoResultLabel.BackColor = Color.Black;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1055);
            Controls.Add(infoResultLabel);
            Name = "PlayForm";
            Text = "Play";
            Load += PlayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoResultLabel;
    }
}