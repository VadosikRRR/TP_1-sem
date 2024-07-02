using System;

namespace HelpDateProgram
{
    public class Program
    {
        static void Main()
        {
            DateTime dt1 = new DateTime(1940, 5, 11);
            DateTime dt2 = new DateTime(1942, 3, 23);
            Console.WriteLine(CountWeek(dt1, dt2));
        }

        public static int CountWeek(DateTime dt1, DateTime dt2)
        {
            if (dt1 > dt2)
            {
                (dt1, dt2) = (dt2, dt1);
            }
            while (dt1.DayOfWeek != DayOfWeek.Monday)
            {
                dt1 = dt1.AddDays(1);
            }

            while (dt2.DayOfWeek != DayOfWeek.Monday)
            {
                dt2 = dt2.AddDays(-1);
            }

            return (int)(dt2 - dt1).TotalDays / 7;
        }
    }
}