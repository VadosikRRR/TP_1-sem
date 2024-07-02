namespace Matrix
{
    public class Program
    {
        private static void Main()
        {
            int heigth;
            int width;

            Console.WriteLine("Введите количество строк у матрицы.\nЕсли размеры матриц Вы введёте отрицательные, то я возьму от них модуль.");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out heigth))
                {
                    if (heigth < 0)
                        heigth = -heigth;

                    break;
                }

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.WriteLine("\nА теперь стобцов)\n");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out width))
                {
                    if (width < 0)
                        width = -width;
                    break;
                }

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            int[,] matrix = new int[heigth, width];
            string[] input = { };

            if (heigth * width > 0)
            {
                Console.WriteLine("\nТеперь вводите строки матрицы, все числа нужно вводить через пробел.\nПожалуйста, не вводите строки разной длины)\n");
            }

            bool helpBool = true;
            for (int i = 0; i < heigth; i++)
            {
                input = (Console.ReadLine()).Split(' ');

                for (int j = 0; j < width; j++)
                {
                    if ((int.TryParse(input[j], out matrix[i, j])) && input.Length == width)
                        continue;
                    else
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);

                        j = width;
                        helpBool = false;
                    }
                }

                if (!helpBool)
                {
                    i--;
                    helpBool = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine(differenceBlockMatrix(matrix));
            Console.ReadLine();
        }

        public static int differenceBlockMatrix(int[,] matrix)
        {
            CheckMatrix(matrix);

            int sumUpperLeft = 0;
            int sumLowerRight = 0;

            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    sumUpperLeft += matrix[i, j];
                    sumLowerRight += matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j];
                }
            }

            return sumUpperLeft - sumLowerRight;
        }

        private static void CheckMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0 || matrix.GetLength(0) >= 1000 || matrix.GetLength(1) >= 1000)
            {
                throw new MatrixIsNotCorrectException("Matrix size is not correct");
            }
        }
    }
}