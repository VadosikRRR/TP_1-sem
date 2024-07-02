namespace GuessTheNumber
{
    public partial class StatisticsForm : Form
    {
        private PictureBox _gifStatisticsPictureBox = new();
        public StatisticsForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            _gifStatisticsPictureBox.Image = Image.FromFile(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\backGroundGif.gif");
            _gifStatisticsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _gifStatisticsPictureBox.Dock = DockStyle.Fill;
            Controls.Add(_gifStatisticsPictureBox);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            staticsLabel.ForeColor = Color.LimeGreen;
            staticsLabel.BackColor = Color.Black;
            staticsLabel.Font = new Font("Courier New", 20);
            staticsLabel.Text = "Количество побед: " + MainForm.ListTextForStatics[0].ToString() + "\n"
                + "Количество поражений: " + MainForm.ListTextForStatics[1].ToString();

            buttonClose.ForeColor = Color.LimeGreen;
            buttonClose.BackColor = Color.Black;
            buttonClose.Font = new Font("Courier New", 40);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Size = new Size(ClientSize.Width / 4, ClientSize.Height / 4);
            buttonClose.Location = new Point((ClientSize.Width - buttonClose.Width) / 2, ClientSize.Height / 2);
            buttonClose.FlatAppearance.BorderSize = 0;
            MainForm.RoundFrameForButton(buttonClose, 20);
        }
    }
}
