using System;

namespace NSStackException
{
    public class StackException: Exception
    {
        public StackException(string message) : base(message) { }
    }
}
