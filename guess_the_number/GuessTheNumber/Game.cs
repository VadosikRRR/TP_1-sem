namespace GuessTheNumber
{
    public class Game
    {
        public const int COUNTBUTTON = 10;
        private static Random _random = new();
        public List<int> TheRestOfButtons { get; set; } = new List<int>(GeneratingAnArrayOfNumbers());
        private int ThereAreStillAttemptsLeft = 2;
        public int Answer { get; set; } = _random.Next(COUNTBUTTON);

        public Game() { }

        public string ChoosingNumber(int theValueNow)
        {
            if (theValueNow == Answer)
            {
                return "Win";
            }
            else if (theValueNow > Answer && ThereAreStillAttemptsLeft > 0)
            {
                ThereAreStillAttemptsLeft--;
                return "Less";
            }
            else if (theValueNow < Answer && ThereAreStillAttemptsLeft > 0)
            {
                ThereAreStillAttemptsLeft--;
                return "More";
            }
            else { return "Loss"; }
        }

        public static void AddAttemptToTheStatistics(bool isWin)
        {
            int index = isWin ? 0 : 1;
            int trashValue = int.Parse(MainForm.ListTextForStatics[index].ToString()) + 1;
            MainForm.ListTextForStatics[index] = new(trashValue.ToString());
            using StreamWriter sw = File.CreateText(@"D:\C#\GuessTheNumber\GuessTheNumber\bin\statics.txt");
            sw.WriteLine(MainForm.ListTextForStatics[0]);
            sw.WriteLine(MainForm.ListTextForStatics[1]);
        }

        private static int[] GeneratingAnArrayOfNumbers()
        {
            int[] ints = new int[COUNTBUTTON];
            for (int i = 0; i < COUNTBUTTON; i++)
            {
                ints[i] = i;
            }
            return ints;
        }
    }
}
