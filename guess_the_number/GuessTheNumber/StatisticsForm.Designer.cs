namespace GuessTheNumber
{
    partial class StatisticsForm
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
            staticsLabel = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // staticsLabel
            // 
            staticsLabel.AutoSize = true;
            staticsLabel.Location = new Point(19, 24);
            staticsLabel.Name = "staticsLabel";
            staticsLabel.Size = new Size(50, 20);
            staticsLabel.TabIndex = 0;
            staticsLabel.Text = "label1";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(344, 276);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(158, 97);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "В меню";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(staticsLabel);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staticsLabel;
        private Button buttonClose;
    }
}