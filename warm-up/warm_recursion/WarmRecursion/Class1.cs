using System;


namespace WarmUpRecursion
{
    public class NumbersIsNotCorrectException : Exception
    {
        public NumbersIsNotCorrectException() { }

        public NumbersIsNotCorrectException(string message)
            : base(message) { }
    }
}
