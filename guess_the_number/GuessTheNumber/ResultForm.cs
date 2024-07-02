namespace GuessTheNumber
{
    public partial class ResultForm : Form
    {
        private PictureBox _gifResultPictureBox = new();
        public ResultForm(bool wasWin = true)
        {
            InitializeComponent(wasWin);
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            _gifResultPictureBox.Image = Image.FromFile(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\backGroundGif.gif");
            _gifResultPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _gifResultPictureBox.Dock = DockStyle.Fill;
            Controls.Add(_gifResultPictureBox);
        }


        private void ResultForm_Load(object sender, EventArgs e)
        {
            resultLabel.Location = new Point((ClientSize.Width - resultLabel.Width) / 2, (ClientSize.Height - resultLabel.Width) / 2);

            buttonClose.Size = new Size(ClientSize.Width / 4, ClientSize.Height / 4);
            buttonClose.Location = new Point((ClientSize.Width - buttonClose.Width) / 2, ClientSize.Height / 2);
            MainForm.RoundFrameForButton(buttonClose, 20);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private string ResultGame(bool wasWin)
        {
            return wasWin ? "You WIN!" : "Wasted";
        }
    }
}
