using System;
using System.Globalization;
using System.Text;
using Humanizer;

namespace Spanish
{
    internal class Program
    {
        private static void Main()
        {
            for (int num = 1; num <= 1000000; num++)
            {
                if (num % 100000 == 0) { Console.WriteLine(num); }
                if (TranslateToSpanish(num)[1] == num.ToWords(GrammaticalGender.Feminine, new CultureInfo("es"))) 
                {
                    continue;
                }

                Console.WriteLine(TranslateToSpanish(num)[1]);
                Console.WriteLine(num.ToWords(GrammaticalGender.Feminine, new CultureInfo("es")));
            }

            _ = Console.ReadLine();
        }

        private static string SpanishWordsToString(string[] spanishWords)
        {
            StringBuilder numberInSpanish = new StringBuilder();

            foreach (string word in spanishWords)
            {
                if (word == null || word == " mil" || word == " millones" || word == "")
                {
                    continue;
                }
                
                _ = numberInSpanish.Append(numberInSpanish.Length == 0 ? word : " " + word);
            }
            return numberInSpanish.ToString();
        }
        private static string ConverThreeDigitstToString(int num)
        {
            string[] zeroToNine = { "cero", "uno", "dos", "tres", "cuatro", "cinco"
                    , "seis", "siete", "ocho", "nueve" };
            string[] firstDozen = { "diez", "once", "doce", "trece", "catorce", "quince"
                    , "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] secondDozen = { "veinte", "veintiuno", "veintidós", "veintitrés", "veinticuatro"
                    , "veinticinco", "veintiséis", "veintisiete", "veintiocho", "veintinueve" };
            string[] dozens = { "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta"
                    , "setenta", "ochenta", "noventa" };
            string[] hundreds = { "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos"
                    , "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string units = null, dozen = null, hundred = null;

            if ((num % 100 <= 9 || num % 100 >= 30) && num % 10 != 0)
            {
                units = zeroToNine[num % 10];
            }

            if (num % 100 >= 10 && num % 100 <= 19)
            {
                dozen = firstDozen[num % 10];
            }
            else if (num % 100 >= 20 && num % 100 <= 29)
            {
                dozen = secondDozen[num % 10];
            }
            else if (num % 100 >= 30)
            {
                dozen = dozens[(num % 100 - num % 10) / 10 - 1] + (num % 10 != 0 ? " y" : null);
            }

            if (num == 100)
            {
                hundred = "cien";
            }
            else if (num > 100)
            {
                hundred = hundreds[(num - num % 100) / 100 - 1];
            }

            string[] digitsInNumbers = { hundred, dozen, units };
            return SpanishWordsToString(digitsInNumbers);
        }
        private static string[] TranslateToSpanish(int num)
        {
            string firstThreesInNumber = ConverThreeDigitstToString(num % 1000);

            int thousands = (num / 1000) % 1000;
            string secondThreesInNumber = thousands == 1 ? "mil" 
                : ConverThreeDigitstToString(thousands) + " mil";

            int millions = (num / 1000000) % 1000;
            string thirdThreesInNumber = millions == 1 ? "un millón" 
                : ConverThreeDigitstToString(millions) + " millones";

            string[] threesInNumbersInSpanish = { thirdThreesInNumber, secondThreesInNumber, firstThreesInNumber };
            string number = SpanishWordsToString(threesInNumbersInSpanish);

            switch (num)
            {
                case 0:
                    number = "cero";
                    break;
                case 1000000000:
                    number = "mil millones";
                    break;
            }

            string[] arrayOfSpanishNums = GenderChanger(number);
            return arrayOfSpanishNums;
        }
        private static string[] GenderChanger(string numberInSpanish)
        {
            string[] hundreds = { "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos"
                    , "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string[] femHundreds = { "ciento", "doscientas", "trescientas", "cuatrocientas"
                    , "quinientas", "seiscientas", "setecientas", "ochocientas", "novecientas" };
            string[] arrayOfWordsNumber = numberInSpanish.Split(' ');
            string[] femArrayOfWordsNumber = numberInSpanish.Split(' ');
            string[] musArrayOfWordsNumber = numberInSpanish.Split(' ');

            for (int ind = 0; ind < arrayOfWordsNumber.Length; ind++)
            {
                if (arrayOfWordsNumber[ind] == "uno")
                {
                    femArrayOfWordsNumber[ind] = "una";
                }
                else if (arrayOfWordsNumber[ind] == "veintiuno")
                {
                    femArrayOfWordsNumber[ind] = "veintiuna";
                    musArrayOfWordsNumber[ind] = "veintiun";
                }

                for (int j = 0; j < hundreds.Length; j++)
                {
                    if (arrayOfWordsNumber[ind] == hundreds[j])
                    {
                        femArrayOfWordsNumber[ind] = femHundreds[j];
                    }
                }
            }

            string femNumberInSpanish = SpanishWordsToString(femArrayOfWordsNumber);
            string musNumberInSpanish = SpanishWordsToString(musArrayOfWordsNumber);
            string[] newString = { numberInSpanish, femNumberInSpanish, musNumberInSpanish };
            return newString;
        }
    }
}