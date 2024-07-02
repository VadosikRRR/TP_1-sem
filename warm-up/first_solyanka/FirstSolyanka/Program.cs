using System.Text;

namespace FirstSolyanka
{
    public class Program
    {
        private static void Main()
        {

            while (true)
            {
                Console.WriteLine("Введите число, принадлежащее типу Int32.\nЕсли введёте отрицательное число, то я сделаю его положительным)");

                if (int.TryParse(Console.ReadLine(), out int N))
                {
                    if (N >= 0)
                        GenerateMors(N);
                    else
                        GenerateMors(-N);
                    break;
                }
                Console.Clear();
            }
        }

        public static string GenerateMors(int N)
        {
            CheckNumber(N);

            if (N == 0)
            {
                return "0";
            }

            bool[] arrayMorsaTue = { true };

            while (arrayMorsaTue.Length < N)
            {
                bool[] oppositeArray = new bool[arrayMorsaTue.Length];
                bool[] helpArray = new bool[2 * arrayMorsaTue.Length];

                for (int ind = 0; ind < arrayMorsaTue.Length; ind++)
                {
                    oppositeArray[ind] = !arrayMorsaTue[ind];
                    helpArray[ind] = arrayMorsaTue[ind];
                }

                for (int ind = 0; ind < arrayMorsaTue.Length; ind++)
                {
                    helpArray[ind + arrayMorsaTue.Length] = oppositeArray[ind];
                }

                arrayMorsaTue = helpArray;
            }

            Console.WriteLine("\nПоследовательность Морса-Туэ до " + Convert.ToString(N) + " члена\n");

            StringBuilder sequenceMorsaTue = new();

            for (int ind = 0; ind < N; ind++)
            {
                _ = sequenceMorsaTue.Append((arrayMorsaTue[ind] == true) ? 1 : 0);
            }

            Console.WriteLine(sequenceMorsaTue.ToString());

            return sequenceMorsaTue.ToString();
        }

        private static void CheckNumber(int N)
        {
            if (N < 0 || N >= 10000)
            {
                throw new NumberIsNotCorrectException("Number is very big or negative");
            }
        }
    }
}