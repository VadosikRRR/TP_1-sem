using System;
using System.IO;
using System.Text;

namespace Files
{
    public class Program
    {
        private const string PATH = @".\text.txt";
        private static void Main()
        {
            Console.Write("Введите подстроку, которую хотите заменить на новую: ");
            string oldStr = InputString();

            Console.Write("Введите подстроку, на которую хотите заменить: ");
            string newStr = InputString();

            ReplaceInTheText(PATH, oldStr, newStr);

            Console.WriteLine("Successfully!");
            _ = Console.ReadLine();
        }

        public static void ReplaceInTheText(string path, string oldStr, string newStr)
        {
            string text;
            using (StreamReader sr = File.OpenText(path))
            {
                text = sr.ReadToEnd();
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(Replace(text, oldStr, newStr));
            }
        }

        private static string Replace(string text, string oldStr, string newStr)
        {
            //ArgumentNullException.ThrowIfNull(text, nameof(text));

            if (string.IsNullOrEmpty(oldStr))
            {
                throw new ArgumentNullException(nameof(oldStr));
            }

            StringBuilder saveText = new StringBuilder(text);
            int ind;
            while ((ind = FindIndexOfTheOccurrenceOfStringInText(saveText, oldStr)) != -1)
            {
                saveText.Remove(ind, oldStr.Length);
                saveText.Insert(ind, newStr);
            }
            return saveText.ToString();
        }

        private static int FindIndexOfTheOccurrenceOfStringInText(StringBuilder text, string str)
        {
            for (int i = 0; i < text.Length; i++)
            {
                for (int k = 0; k < str.Length; k++)
                {
                    if ((text.Length - i < str.Length) || (text[i + k] != str[k]))
                    {
                        break;
                    }
                    if (k == str.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private static string InputString()
        {
            string inputStr;

            while (true) 
            {
                inputStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputStr))
                {
                    return inputStr;
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
