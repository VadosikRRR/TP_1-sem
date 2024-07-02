using System;
using WarmUpRecursion;

namespace NSWarmRecursion
{
    public class WarmRecursion
    {
        private static void Main()
        {
            int[] numbers = new int[8];
            numbers[7] = 1;

            Console.WriteLine("Введите переменные в таком порядке: N1, M1, N2, M2, N3, M3, K");

            for (int cnt = 0; cnt < 7; cnt++)
            {
                numbers[cnt] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Check(new int[] { 1, 2, 2, 3, 8, 13, 5, 1 }));
        }

        public static bool Check(int[] numbers)
        {
            DataIsCorrect(numbers);

            if (numbers[7] > numbers[6])
                return numbers[4] == 0 && numbers[5] == 0 && numbers[4] == 0;

            if (numbers[0] * numbers[7] + numbers[2] * (numbers[6] - numbers[7]) == numbers[4]
                &&
                numbers[1] * numbers[7] + numbers[3] * (numbers[6] - numbers[7]) == numbers[5])
            {
                return true;
            }

            numbers[7]++;
            return Check(numbers);

        }

        public static void DataIsCorrect(int[] numbers)
        {
            foreach (int elem in numbers)
            {
                if (elem < 0)
                {
                    throw new NumbersIsNotCorrectException("Sorry, numbers is bad(");
                }
            }
        }
    }
}