namespace FirstSolyanka
{
    public class NumberIsNotCorrectException: Exception
    {
        public NumberIsNotCorrectException() { }

        public NumberIsNotCorrectException(string message) : base(message) { }

        public NumberIsNotCorrectException(string message, Exception innerException) : base(message, innerException) { }
    }
}
