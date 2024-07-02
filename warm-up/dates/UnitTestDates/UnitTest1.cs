using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dates;
using HelpDateProgram;

namespace UnitTestDates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOfTwoPrograms()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int day1 = random.Next(1, 28);
                int month1 = random.Next(1, 12);
                int year1 = random.Next(1700, 2500);

                int day2 = random.Next(1, 28);
                int month2 = random.Next(1, 12);
                int year2 = random.Next(1700, 2500);

                Date date1 = new Date(year1, month1, day1);
                Date date2 = new Date(year2, month2, day2);

                DateTime dt1 = new DateTime(year1, month1, day1);
                DateTime dt2 = new DateTime(year2, month2, day2);

                Assert.AreEqual(date1 - date2, Program.CountWeek(dt1, dt2));
            }
        }

        [TestMethod]
        public void DateWithNegativeNumbers()
        {
            _ = Assert.ThrowsException<DateIsNotCorrectException>(() => new Date(-1, -1, -1));
        }

        [TestMethod]
        public void IncorrectDate() 
        {
            _ = Assert.ThrowsException<DateIsNotCorrectException>(() => new Date(2003, 13, 9));
            _ = Assert.ThrowsException<DateIsNotCorrectException>(() => new Date(2003, 12, 32));
        }

        [TestMethod]
        public void CheckDiffirenceDatesOnSpecialVariant() 
        {
            Date date1 = new Date(2023, 10, 16);
            Date date2 = new Date(2023, 10, 23);
            Assert.AreEqual(date1 - date2, 1);

            date1 = new Date(2024, 8, 6);
            date2 = new Date(2024, 8, 12);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2022, 1, 3);
            date2 = new Date(2022, 1, 9);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2024, 3, 5);
            date2 = new Date(2024, 3, 17);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2023, 10, 10);
            date2 = new Date(2023, 10, 23);
            Assert.AreEqual(date1 - date2, 1);
        }

        [TestMethod]
        public void LeapYear()
        {
            _ = Assert.ThrowsException<DateIsNotCorrectException>(() => new Date(2003, 2, 29));
            _ = new Date(2004, 2, 29);
        }

        [TestMethod]
        public void CheckDiffirenceDatesOnSpecialVariantWithLeapYear()
        {
            Date date1 = new Date(2024, 2, 26);
            Date date2 = new Date(2024, 3, 4);
            Assert.AreEqual(date1 - date2, 1);

            date1 = new Date(2024, 2, 27);
            date2 = new Date(2024, 3, 4);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2024, 2, 26);
            date2 = new Date(2024, 3, 3);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2024, 2, 20);
            date2 = new Date(2024, 3, 3);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2024, 2, 20);
            date2 = new Date(2024, 3, 10);
            Assert.AreEqual(date1 - date2, 1);
        }

        [TestMethod]
        public void CheckDiffirenceDatesOnSpecialVariantWithNewYear()
        {
            Date date1 = new Date(2023, 12, 25);
            Date date2 = new Date(2024, 1, 1);
            Assert.AreEqual(date1 - date2, 1);

            date1 = new Date(2023, 12, 26);
            date2 = new Date(2024, 1, 1);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2023, 12, 26);
            date2 = new Date(2024, 1, 7);
            Assert.AreEqual(date1 - date2, 0);

            date1 = new Date(2023, 12, 26);
            date2 = new Date(2024, 1, 14);
            Assert.AreEqual(date1 - date2, 1);
        }

        [TestMethod]
        public void DaysWeek()
        {
            Date date1 = new Date(2023, 10, 23);
            Assert.AreEqual(date1.DayWeek, NSDaysWeek.DaysWeek.Monday);

            Date date2 = new Date(1900, 1, 1);
            Assert.AreEqual(date2.DayWeek, NSDaysWeek.DaysWeek.Monday);

            Date date3 = new Date(2023, 11, 22);
            Assert.AreEqual(date3.DayWeek, NSDaysWeek.DaysWeek.Wednesday);

            Date date4 = new Date(2003, 12, 9);
            Assert.AreEqual(date4.DayWeek, NSDaysWeek.DaysWeek.Tuesday);
        }

        [TestMethod]

        public void NextDay()
        {
            Date date1 = new Date(2023, 10, 23);
            date1.NextDay();
            Assert.AreEqual(date1.Day, 24);
            Assert.AreEqual(date1.Month, 10);
            Assert.AreEqual(date1.Year, 2023);
            Assert.AreEqual(date1.DayWeek, NSDaysWeek.DaysWeek.Tuesday);

            Date date2 = new Date(2023, 12, 31);
            date2.NextDay();
            Assert.AreEqual(date2.Day, 1);
            Assert.AreEqual(date2.Month, 1);
            Assert.AreEqual(date2.Year, 2024);
            Assert.AreEqual(date2.DayWeek, NSDaysWeek.DaysWeek.Monday);

            Date date3 = new Date(2003, 12, 8);
            date3.NextDay();
            Assert.AreEqual(date3.Day, 9);
            Assert.AreEqual(date3.Month, 12);
            Assert.AreEqual(date3.Year, 2003);
            Assert.AreEqual(date3.DayWeek, NSDaysWeek.DaysWeek.Tuesday);

        }

        [TestMethod]
        public void LastDay()
        {
            Date date1 = new Date(2023, 10, 23);
            date1.LastDay();
            Assert.AreEqual(date1.Day, 22);
            Assert.AreEqual(date1.Month, 10);
            Assert.AreEqual(date1.Year, 2023);
            Assert.AreEqual(date1.DayWeek, NSDaysWeek.DaysWeek.Sunday);

            Date date2 = new Date(2024, 1, 1);
            date2.LastDay();
            Assert.AreEqual(date2.Day, 31);
            Assert.AreEqual(date2.Month, 12);
            Assert.AreEqual(date2.Year, 2023);
            Assert.AreEqual(date2.DayWeek, NSDaysWeek.DaysWeek.Sunday);

            Date date3 = new Date(2003, 12, 9);
            date3.LastDay();
            Assert.AreEqual(date3.Day, 8);
            Assert.AreEqual(date3.Month, 12);
            Assert.AreEqual(date3.Year, 2003);
            Assert.AreEqual(date3.DayWeek, NSDaysWeek.DaysWeek.Monday);
        }
    }
}
