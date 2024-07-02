namespace GuessTheNumber
{
    partial class MainForm
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
            infoLabel = new Label();
            buttonPlay = new Button();
            buttonStatistics = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = SystemColors.Desktop;
            infoLabel.ForeColor = Color.LawnGreen;
            infoLabel.Location = new Point(377, 91);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(50, 20);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "label1";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoLabel.Click += InfoLabel_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.AutoSize = true;
            buttonPlay.BackColor = SystemColors.Desktop;
            buttonPlay.BackgroundImageLayout = ImageLayout.Center;
            buttonPlay.ForeColor = Color.LawnGreen;
            buttonPlay.Location = new Point(319, 168);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(192, 67);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "button1";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += ButtonPlay_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.AutoEllipsis = true;
            buttonStatistics.BackColor = SystemColors.Desktop;
            buttonStatistics.ForeColor = Color.LawnGreen;
            buttonStatistics.Location = new Point(468, 299);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(94, 29);
            buttonStatistics.TabIndex = 2;
            buttonStatistics.Text = "button1";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += ButtonStatistics_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.Desktop;
            buttonClose.ForeColor = Color.LawnGreen;
            buttonClose.Location = new Point(296, 283);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(123, 48);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "button1";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonPlay);
            Controls.Add(infoLabel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainForm";
            Text = "Menu";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private Button buttonPlay;
        private Button buttonStatistics;
        private Button buttonClose;
    }
}