namespace GuessTheNumber
{
    partial class ResultForm
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
        private void InitializeComponent(bool wasWin = true)
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Text = "Result";
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainForm";
            Text = "Form1";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
            resultLabel = new()
            {
                Name = "resultLabel",
                TabIndex = 0,
                Text = ResultGame(wasWin),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.LimeGreen,
                BackColor = Color.Black,
                Font = new Font("Courier New", 50),
            };
            Controls.Add(resultLabel);
            resultLabel.Show();

            buttonClose = new()
            {
                Name = "buttonClose",
                TabIndex = 0,
                Text = "В меню",
                UseVisualStyleBackColor = true,
                ForeColor = Color.LimeGreen,
                BackColor = Color.Black,
                Font = new Font("Courier New", 35),
                FlatStyle = FlatStyle.Flat
            };
            Controls.Add(buttonClose);
            buttonClose.Click += new EventHandler(Button_Click);
            buttonClose.Show();
            buttonClose.FlatAppearance.BorderSize = 0;
        }

        private Label resultLabel = new();
        private Button buttonClose = new();
        #endregion
    }
}