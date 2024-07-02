using System;
using NSStackException;

namespace StackNS
{
    public class Stack
    {
        public string[] mainArray = { };

        // Push будет лучше
        public void Add(string elem)
        {
            string[] additionalArray = new string[mainArray.Length + 1];
            //for (int ind = 0; ind < mainArray.Length; ind++)
            //{
            //    additionalArray[ind] = mainArray[ind];
            //}
            Array.Copy(mainArray, additionalArray, mainArray.Length);
            additionalArray[mainArray.Length] = elem;
            mainArray = additionalArray;
        }
        public void Pop()
        {
            // писать на консоль при ошибке не самое лучшее решение
            if (mainArray.Length != 0)
            {
                string[] additionalArray = new string[mainArray.Length - 1];
                for (int ind = 0; ind < mainArray.Length - 1; ind++)
                {
                    additionalArray[ind] = mainArray[ind];
                }
                mainArray = additionalArray;
            }
            else
            {
                throw new StackException("Stack is empty");
            }
        }

        public string[] Return()
        {
            return mainArray;
        }

        public string Peek()
        {
            if (mainArray.Length != 0)
            {
                return mainArray[mainArray.Length - 1];
            }
            throw new StackException("Stack is empty");
        }

        public int Count()
        {
            return mainArray.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            Stack myStack = new Stack();
            myStack.Add("10");
            myStack.Pop();
            myStack.Add("11");

            Console.ReadLine();
        }
    }
}
