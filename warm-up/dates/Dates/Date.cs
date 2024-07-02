using System;
using NSDaysWeek;

namespace Dates
{
    public class Date
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public DaysWeek DayWeek { get; private set; } = DaysWeek.Saturday;

        public static int operator -(Date date1, Date date2) // оператор находит разницу в полных неделях
        {
            int count = 0;
            if (date1 < date2)
            {
                (date1.Year, date2.Year) = (date2.Year, date1.Year);
                (date1.Month, date2.Month) = (date2.Month, date1.Month);
                (date1.Day, date2.Day) = (date2.Day, date1.Day);
                (date1.DayWeek, date2.DayWeek) = (date2.DayWeek, date1.DayWeek);
            }
            while (date1.Year != date2.Year || date1.Month != date2.Month || date1.Day != date2.Day)
            {
                if (date2.DayWeek == DaysWeek.Monday) { count++; }
                date2.NextDay();
            }
            if (date2.DayWeek == DaysWeek.Monday) { count++; }
            return count == 0 ? 0 : --count;
        }

        public static bool operator >(Date date1, Date date2)
        {
            return !CopmarisonDate(date1, date2);
        }
        public static bool operator <(Date date1, Date date2)
        {
            return CopmarisonDate(date1, date2);
        }

        public Date()
            : this(2000, 1, 1) { }

        public Date(int year, int month, int day)
        {

            if (!AnalyzeData(year, month, day))
            {
                throw new DateIsNotCorrectException("Date is not correct");
            }

            Year = year; Month = month; Day = day;

            DetermineTheDayOfTheWeek();
        }

        private void DetermineTheDayOfTheWeek()
        {
            int year, month, day;
            year = Year; month = Month; day = Day;
            int yearHelp = 2000, monthHelp = 1, dayHelp = 1;
            DaysWeek dayWeekHelp = DaysWeek.Saturday;

            if (Year >= 2000)
            {
                while (Year != yearHelp || Month != monthHelp || Day != dayHelp)
                {
                    LastDay();
                }
            }
            else
            {
                while (Year != yearHelp || Month != monthHelp || Day != dayHelp)
                {
                    NextDay();
                }
            }
            DaysWeek dayWeekHelpOnlyForCalculation = DayWeek;
            DayWeek = dayWeekHelp;

            if (dayWeekHelp - dayWeekHelpOnlyForCalculation >= 0)
            {
                for (int i = 0; i < dayWeekHelp - dayWeekHelpOnlyForCalculation; i++)
                {
                    NextDayWeek();
                }
            }
            else
            {
                LastDayWeek();
            }

            Year = year; Month = month; Day = day;
        }

        public void NextDay()
        {
            if (Day == MaxDayInMonth(Year, Month) && Month != 12)
            {
                Month++;
                Day = 1;
                NextDayWeek();
            }
            else if (Day == MaxDayInMonth(Year, Month) && Month == 12)
            {
                Month = 1;
                Day = 1;
                Year++;
                NextDayWeek();
            }
            else
            {
                Day++;
                NextDayWeek();
            }
        }

        public void LastDay()
        {
            if (Day == 1 && Month != 1)
            {
                Month--;
                Day = MaxDayInMonth(Year, Month);
                LastDayWeek();
            }
            else if (Day == 1 && Month == 1)
            {
                Year--;
                Month = 12;
                Day = 31;
                LastDayWeek();
            }
            else
            {
                Day--;
                LastDayWeek();
            }
        }

        private void NextDayWeek()
        {
            if (DayWeek == DaysWeek.Sunday)
            {
                DayWeek = DaysWeek.Monday;
            }
            else
            {
                DayWeek++;
            }
        }

        private void LastDayWeek()
        {
            if (DayWeek == DaysWeek.Monday)
            {
                DayWeek = DaysWeek.Sunday;
            }
            else
            {
                DayWeek--;
            }
        }

        private int MaxDayInMonth(int year, int month)
        {
            int[] arrayDaysInTheMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(year, month))
            {
                return 29;
            }
            return arrayDaysInTheMonth[month];
        }

        private bool IsLeapYear(int year, int month)
        {
            return (month == 2) && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        private bool AnalyzeData(int year, int month, int day)
        // метод, который отвечает за то, чтобы дата была коректная (существующая)
        {
            return month >= 1
                && month <= 12
                && day >= 1
                && day <= MaxDayInMonth(year, month)
                && year >= 0;
        }

        private static bool CopmarisonDate(Date date1, Date date2)
        {
            return date1.Year <= date2.Year
                && (date1.Year != date2.Year || date1.Month <= date2.Month)
                && (date1.Year != date2.Year || date1.Month != date2.Month || date1.Day <= date2.Day);
        }
    }
}
