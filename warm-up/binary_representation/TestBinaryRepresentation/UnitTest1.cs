using NSBinaryRepresentation;

namespace TestBinaryRepresentation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(10, 1);
            ints.Sort();
            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[1], 2);
            Assert.AreEqual(ints[2], 4);
            Assert.AreEqual(ints[3], 8);
            //CollectionAssert.Equals(ints, new int[] { 1, 2, 4, 8 });
            
        }

        [TestMethod]
        public void SimpleTest2()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(25, 1);
            ints.Sort();
            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[1], 2);
            Assert.AreEqual(ints[2], 4);
            Assert.AreEqual(ints[3], 8);
            Assert.AreEqual(ints[4], 16);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(100, 1);
            ints.Sort();
            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[1], 2);
            Assert.AreEqual(ints[2], 4);
            Assert.AreEqual(ints[3], 8);
            Assert.AreEqual(ints[4], 16);
            Assert.AreEqual(ints[5], 32);
            Assert.AreEqual(ints[6], 64);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(10, 3);
            ints.Sort();
            Assert.AreEqual(ints[0], 7);
        }

        [TestMethod]
        public void SimpleTest5()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(18, 2);
            ints.Sort();
            Assert.AreEqual(ints[0], 3);
            Assert.AreEqual(ints[1], 5);
            Assert.AreEqual(ints[2], 6);
            Assert.AreEqual(ints[3], 9);
            Assert.AreEqual(ints[4], 10);
            Assert.AreEqual(ints[5], 12);
            Assert.AreEqual(ints[6], 17);
        }

        [TestMethod]
        public void SimpleTest6()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(50, 4);
            ints.Sort();
            Assert.AreEqual(ints[0], 15);
            Assert.AreEqual(ints[1], 23);
            Assert.AreEqual(ints[2], 27);
            Assert.AreEqual(ints[3], 29);
            Assert.AreEqual(ints[4], 30);
            Assert.AreEqual(ints[5], 39);
            Assert.AreEqual(ints[6], 43);
            Assert.AreEqual(ints[7], 45);
            Assert.AreEqual(ints[8], 46);
        }

        [TestMethod]
        public void SimpleTest7() 
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(50, 0);
            ints.Sort();
            Assert.AreEqual(ints[0], 0);
        }

        [TestMethod] 
        public void SimpleTest8() 
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(40, 5);
            ints.Sort();
            Assert.AreEqual(ints[0], 31);
        }

        [TestMethod]
        public void SimpleTest9()
        {
            List<int> ints = BinaryRepresentation.NumbersHaveMUnits(100, 6);
            ints.Sort();
            Assert.AreEqual(ints[0], 63);
            Assert.AreEqual(ints[1], 95);
        }

        [TestMethod]
        public void TestWithBadData()
        {
            _ = Assert.ThrowsException<NumbersIsNotCorrectException>(() => BinaryRepresentation.NumbersHaveMUnits(-1, -1));
        }
    }
}