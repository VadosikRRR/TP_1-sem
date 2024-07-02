using System;

namespace Dates
{
    public class DateIsNotCorrectException: ApplicationException
    {
        public DateIsNotCorrectException() { }

        public DateIsNotCorrectException(string message) 
            : base(message) { }

        public DateIsNotCorrectException(string message,  Exception innerException) 
            : base(message, innerException) { }
    }
}
