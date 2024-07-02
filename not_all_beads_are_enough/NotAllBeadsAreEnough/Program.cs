using System;

namespace NotAllBeadsAreEnough
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите количество красных бусинок");
            int redCount = InputNumber();

            Console.WriteLine("Введите количество синих бусинок");
            int blueCount = InputNumber();

            Console.WriteLine("Введите длину бус");
            int length = InputNumber();

            Console.WriteLine(NumberOfBeadVariant(redCount, blueCount, length));
            Console.ReadLine();
        }

        private static int NumberOfBeadVariant(int redRemains, int blueRemains, int length, int red = 0, int green = 0, int count = 0, int currentLength = 0)
        {
            /*
             * if (k == 0)
             *  return 0;
             * return NumberOfBeadVariant(..., i, h-1) + 
             *  NumberOfBeadVariant(..., i+1, h-1) +
             *  NumberOfBeadVariant(..., i+i, h)
             */

            /*
            return expr1
                ? NumberOfBeadVariant()
                : expr2
                ? NumberOfBeadVariant()
                : expr3
                ? NumberOfBeadVariant()
                : -1;
            */

            if (currentLength == length) { return ++count; }
            currentLength++;

            if (redRemains != 0 && currentLength % 2 == 1)
            {
                count = NumberOfBeadVariant(redRemains - 1, blueRemains, length, red + 1, 0, count, currentLength);
            }

            if (red == 0 && blueRemains != 0)
            {
                count = NumberOfBeadVariant(redRemains, blueRemains - 1, length, 0, 0, count, currentLength);
            }

            if (green < 2)
            {
                count = NumberOfBeadVariant(redRemains, blueRemains, length, 0, green + 1, count, currentLength);
            }

            return count;
            /*
            return ((redRemains != 0 && currentLength % 2 == 1) ?
                NumberOfBeadVariant(redRemains - 1, blueRemains, length, red + 1, 0, count, currentLength) : 0)
                + ((red == 0 && blueRemains != 0) ?
                NumberOfBeadVariant(redRemains, blueRemains - 1, length, 0, 0, count, currentLength) : 0)
                + ((green < 2) ?
                NumberOfBeadVariant(redRemains, blueRemains, length, 0, green + 1, count, currentLength) : 0);
            */
        }

        private static int InputNumber()
        {
            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                Delete();
            }
        }

        private static void Delete()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}