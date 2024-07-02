using System;
using System.Collections.Generic;
using System.Linq;
using NSBinaryRepresentation;

namespace NSBinaryRepresentation
{
    public class BinaryRepresentation
    {
        private static void Main()
        {
            foreach (int item in NumbersHaveMUnits(100, 6))
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> NumbersHaveMUnits(int N, int M)
        {
            NumbersIsNotCorrect(N, M);

            List<int> numbers = new List<int>();

            if (M == 0)
            {
                numbers.Add(0);
                return numbers;
            }

            for (int num = 1; num < N; num++)
            {
                int count = 0, elem = num;

                while (elem != 1)
                {
                    if (elem % 2 == 1)
                    {
                        count++;
                    }
                    elem /= 2;
                }

                if (count + 1 == M)
                {
                    numbers.Add(num);
                }
            }

            return numbers;
        }

        private static void NumbersIsNotCorrect(int N, int M)
        {
            if (N < 0 || M < 0)
            {
                throw new NumbersIsNotCorrectException("Oh, no");
            }
        }
    }
}