using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackNS;
using NSStackException;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void SimpleTestPeek1()
        {
            Stack stack = new Stack();
            stack.Add("AaBb");
            Assert.AreEqual(stack.Peek(), "AaBb");
        }

        [TestMethod]
        public void SimpleTestPeek2()
        {
            Stack stack = new Stack();
            stack.Add("aBs");
            stack.Add("GGG");
            Assert.AreEqual(stack.Peek(), "GGG");
        }

        [TestMethod]
        public void SimpleTestPeek3()
        {
            Stack stack = new Stack();
            stack.Add("Lala");
            stack.Add("Hello");
            stack.Pop();
            Assert.AreEqual(stack.Peek(), "Lala");
        }

        [TestMethod]
        public void SimpleTestPeek4()
        {
            Stack stack = new Stack();
            stack.Add("123");
            stack.Add("321");
            stack.Pop();
            stack.Add("9099");
            Assert.AreEqual(stack.Peek(), "9099");
        }

        [TestMethod]
        public void TestPeekWithNullLength()
        {
            Stack stack = new Stack();
            _ = Assert.ThrowsException<StackException>(() => stack.Peek());

            stack.Add("1");
            Assert.AreEqual(stack.Peek(), "1");
            stack.Pop();
            Assert.AreEqual(stack.Return().Length, 0);

            stack.Add("2");
            stack.Add("3");
            Assert.AreEqual(stack.Peek(), "3");
            Assert.AreEqual(stack.Return().Length, 2);
        }

        [TestMethod]
        public void SimpleTestCount1()
        {
            Stack stack = new Stack();
            stack.Add("123");
            Assert.AreEqual(stack.Count(), 1);
        }

        [TestMethod]
        public void SimpleTestCount2()
        {
            Stack stack = new Stack();
            stack.Add("123");
            stack.Add("423");
            Assert.AreEqual(stack.Count(), 2);
        }

        [TestMethod]
        public void SimpleTestCount3()
        {
            Stack stack = new Stack();
            stack.Add("Asd");
            stack.Add("Sdas");
            stack.Pop();
            Assert.AreEqual(stack.Count(), 1);
        }

        [TestMethod]
        public void SimpleTestCount4()
        {
            Stack stack = new Stack();
            stack.Add("!2");
            stack.Add("ыы_ы");
            stack.Pop();
            stack.Add("qwerty");
            Assert.AreEqual(stack.Count(), 2);
        }

        [TestMethod]
        public void TestCountWithEmplyStack()
        {
            Stack stack = new Stack();
            Assert.AreEqual(stack.Count(), 0);
        }

        [TestMethod]
        public void PopMethodInEmptyStack()
        {
            // кроме этого стоит проверить, что после Pop на пустой стек он продолжает правильно функционировать
            Stack stack = new Stack();
            _ = Assert.ThrowsException<StackException>(() => stack.Pop());

            Assert.AreEqual(stack.Return().Length, 0);

            stack.Add("1");
            Assert.AreEqual(stack.Peek(), "1");
            stack.Pop();
            Assert.AreEqual(stack.Return().Length, 0);

            stack.Add("12");
            stack.Add("34");
            Assert.AreEqual(stack.Peek(), "34");
            Assert.AreEqual(stack.Return().Length, 2);
        }

        [TestMethod]
        public void SimpleTestReturn1()
        {
            Stack stack = new Stack();
            stack.Add("12");
            CollectionAssert.AreEqual(stack.Return(), new string[] { "12" });
        }

        [TestMethod]
        public void SimpleTestReturn2()
        {
            Stack stack = new Stack();
            stack.Add("32");
            stack.Add("as");
            CollectionAssert.AreEqual(stack.Return(), new string[] { "32", "as" });
        }

        [TestMethod]
        public void SimpleTestReturn3()
        {
            Stack stack = new Stack();
            stack.Add("Aaa");
            stack.Add("as");
            stack.Pop();
            CollectionAssert.AreEqual(stack.Return(), new string[] { "Aaa" });
        }

        [TestMethod]
        public void SimpleTestReturn4()
        {
            Stack stack = new Stack();
            stack.Add("Aaa");
            stack.Add("as");
            stack.Pop();
            stack.Add("ldds");
            CollectionAssert.AreEqual(stack.Return(), new string[] { "Aaa", "ldds" });
        }

        [TestMethod]
        public void TestReturnWithEmplyStack()
        {
            Stack stack = new Stack();
            CollectionAssert.AreEqual(stack.Return(), new string[0]);

            stack.Add("9");
            CollectionAssert.AreEqual(stack.Return(), new string[] { "9" });
            stack.Pop();
            CollectionAssert.AreEqual(stack.Return(), new string[0]);
        }
    }
}