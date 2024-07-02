using System;
using NSWarmRecursion;
using WarmUpRecursion;

namespace TestWarmRecursion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // N1 = 1, M1 = 2, N2 = 2, M2 = 3, N3 = 8, M3 = 13, K = 5 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 1, 2, 2, 3, 8, 13, 5, 1 }), true);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // N1 = 1, M1 = 2, N2 = 2, M2 = 3, N3 = 8, M3 = 13, K = 6 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 1, 2, 2, 3, 8, 13, 6, 1 }), false);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            // N1 = 0, M1 = 3, N2 = 2, M2 = 5, N3 = 8, M3 = 26, K = 6 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 0, 3, 2, 5, 8, 26, 6, 1 }), true);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            // N1 = 0, M1 = 3, N2 = 2, M2 = 5, N3 = 8, M3 = 26, K = 2 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 0, 3, 2, 5, 8, 26, 2, 1 }), false);
        }

        [TestMethod]
        public void SimpleTest5()
        {
            // N1 = 3, M1 = 1, N2 = 2, M2 = 5, N3 = 27, M3 = 25, K = 11 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 3, 1, 2, 5, 27, 35, 11, 1 }), true);
        }

        [TestMethod]
        public void SimpleTest6()
        {
            // N1 = 3, M1 = 1, N2 = 2, M2 = 5, N3 = 27, M3 = 25, K = 15 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 3, 1, 2, 5, 3, 2, 1, 1 }), false);
        }

        [TestMethod]
        public void SimpleTest7()
        {
            // N1 = 1, M1 = 1, N2 = 2, M2 = 2, N3 = 3, M3 = 3, K = 2 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 1, 1, 2, 2, 3, 3, 2, 1 }), true);
        }

        [TestMethod]
        public void SimpleTest8()
        {
            // N1 = 1, M1 = 1, N2 = 2, M2 = 2, N3 = 3, M3 = 3, K = 0 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 1, 1, 2, 2, 3, 3, 0, 1 }), false);
        }

        /////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestAllWithSpecialData1()
        {
            // N1 = 0, M1 = 0, N2 = 0, M2 = 0, N3 = 0, M3 = 0, K = 0 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 0, 0, 0, 0, 0, 0, 0, 1 }), true);
        }

        [TestMethod]
        public void TestAllWithSpecialData2()
        {
            // N1 = 1, M1 = 2, N2 = 3, M2 = 4, N3 = 0, M3 = 0, K = 0 => true
            Assert.AreEqual(WarmRecursion.Check(new int[] { 1, 2, 3, 4, 0, 0, 0, 1 }), true);
        }

        [TestMethod]
        public void TestAllWithSpecialData3()
        {
            // N1 = 0, M1 = 0, N2 = 0, M2 = 0, N3 = 2, M3 = 5, K = 0 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 0, 0, 0, 0, 2, 5, 0, 1 }), false);
        }

        [TestMethod]
        public void TestAllWithSpecialData4()
        {
            // N1 = 0, M1 = 0, N2 = 0, M2 = 0, N3 = 0, M3 = 5, K = 0 => false
            Assert.AreEqual(WarmRecursion.Check(new int[] { 0, 0, 0, 0, 0, 5, 0, 1 }), false);
        }

        //////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestAllWithBadData() 
        {
            _ = Assert.ThrowsException<NumbersIsNotCorrectException>(() => WarmRecursion.Check(new int[] { -1, -1, -1, -1, -1, -1, -1, -1 }));
        }
    }
}