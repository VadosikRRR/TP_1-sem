using System;

namespace NSBinaryRepresentation
{
    public class NumbersIsNotCorrectException : Exception
    {
        public NumbersIsNotCorrectException() { }

        public NumbersIsNotCorrectException(string message)
            : base(message) { }
    }
}
