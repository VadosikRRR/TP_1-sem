using System;
using System.Collections.Generic;
using Dates;

namespace DatesAreVeryVeryDifficult
{
    public class ProgramWithDates
    {
        private static void Main() // Основной метод
        {
            Date date1 = InputDate();
            Date date2 = InputDate();
            Console.WriteLine(date1 - date2);
            Console.ReadLine();
        }

        private static bool IsYearCorrect(Date date)
        {
            if (date.Year < 2000)
            {
                Console.WriteLine("Вы уверены? Если ответ 'Yes', то я приму эту дату, если что-то другое, то нет");

                if (Console.ReadLine() != "Yes")
                {
                    Delete();
                    return false;
                }
            }

            return true;
        }
        
        private static Date InputDate()
        // Метод отвечает за ввод даты, чтобы было всё коректно
        {
            Console.WriteLine("Введите дату: день, месяц, год через пробел. Пример: 9 12 2003");

            while (true)
            {
                string[] inputDate =  (Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));

                if (inputDate.Length == 3 && int.TryParse(inputDate[2].ToString(), out int year) &&
                    int.TryParse(inputDate[1].ToString(), out int month) &&
                    int.TryParse(inputDate[0].ToString(), out int day))
                {
                    try
                    {
                        Date date = new Date(year, month, day);
                        IsYearCorrect(date);
                        return date;
                    }
                    catch { }
                }
                Delete();
            }
        }

        private static void Delete() // метод просто удаляет строчки, чтобы не мусорить консоль
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}

