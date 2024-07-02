namespace GuessTheNumber
{
    public partial class PlayForm : Form
    {
        private PictureBox _gifPlayPictureBox = new();
        private readonly Game _game = new();
        private Button[] _buttons = new Button[Game.COUNTBUTTON];
        public PlayForm()
        {
            InitializeComponent();

            for (int i = 0; i < Game.COUNTBUTTON; i++)
            {
                _buttons[i] = new Button
                {
                    Location = new Point(0, 0),
                    Name = "button" + i.ToString(),
                    TabIndex = 0,
                    Text = i.ToString(),
                    UseVisualStyleBackColor = true,
                    ForeColor = Color.LimeGreen,
                    BackColor = Color.Black,
                    Font = new Font("Courier New", 20),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(ClientSize.Width * 10 / 11 / (Game.COUNTBUTTON + 2), ClientSize.Height / (Game.COUNTBUTTON + 2))

                };
                _buttons[i].FlatAppearance.BorderSize = 0;
                SettingUpGameButtons(_buttons[i], i, Game.COUNTBUTTON);
                MainForm.RoundFrameForButton(_buttons[i], 20);
                _buttons[i].Click += new EventHandler(Button_Click);
                Controls.Add(_buttons[i]);
            }

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            _gifPlayPictureBox.Image = Image.FromFile(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\backGroundGif.gif");
            _gifPlayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _gifPlayPictureBox.Dock = DockStyle.Fill;
            Controls.Add(_gifPlayPictureBox);
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            infoResultLabel.Location = new Point((ClientSize.Width - infoResultLabel.Width) / 2,
                ClientSize.Height / 4);
            infoResultLabel.Padding = new Padding(10);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (sender is Button)
            {
                int theValueNow;
                int.TryParse(clickedButton?.Text, out theValueNow);
                string result = _game.ChoosingNumber(theValueNow);

                if (result == "Win")
                {
                    Game.AddAttemptToTheStatistics(true);
                    _ = new ResultForm(true).ShowDialog();
                    Close();
                }
                else if (result == "Less")
                {
                    infoResultLabel.Text = "Загаданное число меньше чем: " + theValueNow.ToString();
                    LocationInfoResultLabel();

                    for (int ind = _game.TheRestOfButtons.IndexOf(theValueNow); ind < _game.TheRestOfButtons.Count; ind++)
                    {
                        _buttons[_game.TheRestOfButtons[ind]].Hide();
                    }
                    _game.TheRestOfButtons.RemoveRange(_game.TheRestOfButtons.IndexOf(theValueNow), _game.TheRestOfButtons.Count - _game.TheRestOfButtons.IndexOf(theValueNow));

                    foreach (int number in _game.TheRestOfButtons)
                    {
                        SettingUpGameButtons(_buttons[number], _game.TheRestOfButtons.IndexOf(number), _game.TheRestOfButtons.Count);
                    }
                }
                else if (result == "More")
                {
                    infoResultLabel.Text = "Загаданное число больше чем: " + theValueNow.ToString();
                    LocationInfoResultLabel();

                    for (int ind = _game.TheRestOfButtons.IndexOf(theValueNow); ind >= 0; ind--)
                    {
                        _buttons[_game.TheRestOfButtons[ind]].Hide();
                    }
                    _game.TheRestOfButtons.RemoveRange(0, _game.TheRestOfButtons.IndexOf(theValueNow));

                    foreach (int number in _game.TheRestOfButtons)
                    {
                        SettingUpGameButtons(_buttons[number], _game.TheRestOfButtons.IndexOf(number), _game.TheRestOfButtons.Count - _game.TheRestOfButtons.IndexOf(theValueNow));
                    }
                }
                else
                {
                    Game.AddAttemptToTheStatistics(false);
                    _ = new ResultForm(false).ShowDialog();
                    Close();
                }
            }
        }

        private void SettingUpGameButtons(Button button, int digit, int theActualRemainderOfTheButtons)
        {
            button.Location = new Point(ClientSize.Width * (digit + 1) / (theActualRemainderOfTheButtons + 2), (ClientSize.Height - button.Height) / 2);
        }


        public void LocationInfoResultLabel()
        {
            infoResultLabel.Location = new Point((ClientSize.Width - infoResultLabel.Width) / 2,
                ClientSize.Height / 4);
        }
    }
}
