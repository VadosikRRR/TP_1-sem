using System.Drawing.Drawing2D;
using System.Text;

namespace GuessTheNumber
{
    public partial class MainForm : Form
    {
        private PictureBox _gifMainPictureBox = new();
        public static List<StringBuilder> ListTextForStatics = new();
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            _gifMainPictureBox.Image = System.Drawing.Image.FromFile(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\backGroundGif.gif");
            _gifMainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _gifMainPictureBox.Dock = DockStyle.Fill;
            Controls.Add(_gifMainPictureBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            infoLabel.Font = new Font("Courier New", 20);
            infoLabel.Text = "Привет!\nЭта игра \"Угадай число\"\n" +
                "Всё просто: за 3 попытки Вы должны угадать число.\nПричём, если отвечаете неправильно, то вам даётся подсказка,\n" +
                "больше ли загаданное число или нет)\nЖелаю удачной игры!";
            infoLabel.Location = new Point((ClientSize.Width - infoLabel.Width) / 2, (ClientSize.Height - (infoLabel.Height * 3)) / 2);
            infoLabel.Padding = new(20);
            RoundFrameForLabel(infoLabel, 20);

            buttonPlay.Text = "Играть!";
            SettingUpTheButton(buttonPlay, 20, true);
            buttonPlay.Location = new Point((ClientSize.Width - buttonPlay.Width) / 2, (ClientSize.Height - buttonPlay.Height) / 2);

            buttonClose.Text = "Выход";
            SettingUpTheButton(buttonClose, 20, false);
            buttonClose.Location = new Point((ClientSize.Width - buttonPlay.Width) / 2, (ClientSize.Height + buttonPlay.Height * 11 / 10) / 2);

            buttonStatistics.Text = "Статистика";
            SettingUpTheButton(buttonStatistics, 20, false);
            buttonStatistics.Location = new Point((ClientSize.Width + buttonPlay.Width / 2 - buttonStatistics.Width) / 2, (ClientSize.Height + buttonPlay.Height * 11 / 10) / 2);

            LoadText();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            new PlayForm().ShowDialog();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            new StatisticsForm().ShowDialog();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static void RoundFrameForLabel(Label needLabel, int borderRadius)
        {
            // Создаем объект GraphicsPath для создания формы с закругленными углами
            GraphicsPath path = new();

            // Создаем закругленную форму
            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // левый верхний угол
            path.AddArc(needLabel.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // правый верхний угол
            path.AddArc(needLabel.Width - borderRadius * 2, needLabel.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // правый нижний угол
            path.AddArc(0, needLabel.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // левый нижний угол

            // Задаем закругленную форму для надписи
            needLabel.Region = new Region(path);
        }

        public static void RoundFrameForButton(Button needButton, int borderRadius)
        {
            // Создаем объект GraphicsPath для создания формы с закругленными углами
            GraphicsPath path = new();

            // Создаем закругленную форму
            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // левый верхний угол
            path.AddArc(needButton.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // правый верхний угол
            path.AddArc(needButton.Width - borderRadius * 2, needButton.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // правый нижний угол
            path.AddArc(0, needButton.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // левый нижний угол

            // Задаем закругленную форму для надписи
            needButton.Region = new Region(path);
        }

        private void SettingUpTheButton(Button button, int borderRadius, bool BigOrSmallSize)
        {
            button.Font = new Font("Courier New", 20);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            if (BigOrSmallSize)
            {
                button.Width = 3 * button.Width;
                button.Height = 2 * button.Height;
            }
            else
            {
                button.Width = buttonPlay.Width * 10 / 21;
                button.Height = buttonPlay.Height;
            }
            button.Padding = new(10);
            RoundFrameForButton(button, borderRadius);
        }
        
        private static void LoadText()
        {            
            using (StreamReader sr = File.OpenText(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\statics.txt"))
            {
                ListTextForStatics.Add(new(sr.ReadLine()));
                ListTextForStatics.Add(new(sr.ReadLine()));
            }
        }
        
    }
}