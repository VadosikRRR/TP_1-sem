namespace Matrix
{
    public class MatrixIsNotCorrectException: Exception
    {
        public MatrixIsNotCorrectException() { }

        public MatrixIsNotCorrectException(string message) : base(message) { }

        public MatrixIsNotCorrectException(string message,  Exception innerException) : base(message, innerException) { }
    }
}
