using FirstSolyanka;

namespace TestSolyanka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {
            Assert.AreEqual(Program.GenerateMors(4), "1001");
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Assert.AreEqual(Program.GenerateMors(2), "10");
        }

        [TestMethod]
        public void SimpleTest3()
        {
            Assert.AreEqual(Program.GenerateMors(10), "1001011001");
        }

        [TestMethod]
        public void SimpleTest4()
        {
            Assert.AreEqual(Program.GenerateMors(3), "100");
        }

        [TestMethod]
        public void SimpleTest5()
        {
            Assert.AreEqual(Program.GenerateMors(8), "10010110");
        }

        [TestMethod]
        public void SimpleTest6()
        {
            Assert.AreEqual(Program.GenerateMors(20), "10010110011010010110");
        }

        [TestMethod]

        public void TestWithSpecialNumber1() 
        {
            Assert.AreEqual(Program.GenerateMors(0), "0");
        }

        [TestMethod]

        public void TestWithSpecialNumber2()
        {
            Assert.ThrowsException<NumberIsNotCorrectException>(() => Program.GenerateMors(-1));
        }

        [TestMethod]

        public void TestWithSpecialNumber3()
        {
            Assert.ThrowsException<NumberIsNotCorrectException>(() => Program.GenerateMors(10000));
        }
    }
}