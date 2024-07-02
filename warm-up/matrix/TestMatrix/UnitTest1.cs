using Matrix;

namespace TestMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {
            int[,] matrix =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 0);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            int[,] matrix =
            {
                { 2, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 1);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            int[,] matrix =
            {
                { 3, 3, 5 },
                { 3, 1, 7 },
                { 5, 7, 1 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 2);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            int[,] matrix =
            {
                { 3, 3, 5, 1 },
                { 3, 1, 7, 1 },
                { 5, 7, 1, 1 },
                { 5, 7, 1, 1 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 6);
        }

        [TestMethod]
        public void SimpleTest5()
        {
            int[,] matrix =
            {
                { 0, 0, 5, 1 },
                { 0, 0, 7, 1 },
                { 5, 7, 1, 1 },
                { 5, 7, 1, 1 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), -4);
        }

        [TestMethod]
        public void SimpleTest6()
        {
            int[,] matrix =
            {
                { 2, 4 },
                { 3, 0 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 2);
        }

        [TestMethod]
        public void SimpleTest7()
        {
            int[,] matrix =
            {
                { -2, -4 },
                { -3, 0 },
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), -2);
        }

        [TestMethod]
        public void TestWithSpecialMatrix1()
        {
            int[,] matrix =
            {
                { 2 }
            };

            Assert.AreEqual(Program.differenceBlockMatrix(matrix), 0);
        }

        [TestMethod]
        public void TestWithSpecialMatrix2()
        {
            int[,] matrix = { };

            Assert.ThrowsException<MatrixIsNotCorrectException>(() => Program.differenceBlockMatrix(matrix));
        }

        [TestMethod]
        public void TestWithSpecialMatrix3()
        {
            int[,] matrix =new int[1000, 1];

            Assert.ThrowsException<MatrixIsNotCorrectException>(() => Program.differenceBlockMatrix(matrix));
        }

        [TestMethod]
        public void TestWithSpecialMatrix4()
        {
            int[,] matrix = new int[1, 1000];

            Assert.ThrowsException<MatrixIsNotCorrectException>(() => Program.differenceBlockMatrix(matrix));
        }
    }
}