using System.IO;
using Files;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProgramFiles
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {
            Files.Program.ReplaceInTheText("Test1.txt", "Hello", "Goodbye");
            string text;

            using StreamReader sr = File.OpenText("Test1.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "Goodbye world! Goodbye world!");

            Files.Program.ReplaceInTheText("Test1.txt", "Goodbye", "Hello");
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Files.Program.ReplaceInTheText("Test2.txt", "Привет", "Ладно");
            string text;

            using StreamReader sr = File.OpenText("Test2.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "Ладно! привет!");

            Files.Program.ReplaceInTheText("Test2.txt", "Ладно", "Привет");
        }

        [TestMethod]
        public void SimpleTest3()
        {
            Files.Program.ReplaceInTheText("Test3.txt", "оКей", "ЗАЧЕМ");
            string text;

            using StreamReader sr = File.OpenText("Test3.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "ОКЕЙокейЗАЧЕМОкЕй");

            Files.Program.ReplaceInTheText("Test3.txt", "ЗАЧЕМ", "оКей");
        }

        [TestMethod]
        public void SimpleTest4()
        {
            Files.Program.ReplaceInTheText("Test4.txt", "Bool", "true");
            string text;

            using StreamReader sr = File.OpenText("Test4.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "trueboollooB");

            Files.Program.ReplaceInTheText("Test4.txt", "true", "Bool");
        }

        [TestMethod]
        public void SimpleTest5()
        {
            Files.Program.ReplaceInTheText("Test5.txt", "abaa", "GGG");
            string text;

            using StreamReader sr = File.OpenText("Test5.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "GGGbaGGG");

            Files.Program.ReplaceInTheText("Test5.txt", "GGG", "abaa");
        }

        [TestMethod]
        public void SimpleTest6()
        {
            Files.Program.ReplaceInTheText("Test6.txt", "abaa", "GGG");
            string text;

            using StreamReader sr = File.OpenText("Test6.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "GGGbaGGG");

            Files.Program.ReplaceInTheText("Test6.txt", "GGG", "abaa");
        }

        [TestMethod]
        public void SimpleTest7()
        {
            Files.Program.ReplaceInTheText("Test7.txt", "!-_+=+=", ".....");
            string text;

            using StreamReader sr = File.OpenText("Test7.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, ".....+=.....");

            Files.Program.ReplaceInTheText("Test7.txt", ".....", "!-_+=+=");
        }

        [TestMethod]
        public void SimpleTest8()
        {
            Files.Program.ReplaceInTheText("Test8.txt", "Мама", "Папа");
            string text;

            using StreamReader sr = File.OpenText("Test8.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "Папа\r\nПапа\r\nмамаПапа\r\nПапа");

            Files.Program.ReplaceInTheText("Test8.txt", "Папа", "Мама");
        }

        [TestMethod]
        public void SimpleTest9()
        {
            Files.Program.ReplaceInTheText("Test9.txt", " ", "");
            string text;

            using StreamReader sr = File.OpenText("Test9.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "Helloworld!Helloworld!Helloworld!");

            Files.Program.ReplaceInTheText("Test9.txt", "Helloworld!", "Hello world! ");
        }

        [TestMethod]
        public void SimpleTest10()
        {
            Files.Program.ReplaceInTheText("Test11.txt", "22", "2");
            string text;

            using StreamReader sr = File.OpenText("Test11.txt");
            text = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(text, "2");
        }

        [TestMethod]
        public void TestWithEmptyString()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Files.Program.ReplaceInTheText("Test10.txt", "", "aaa"));
        }

        [TestMethod]
        public void SimpleTest12()
        {
            Assert.ThrowsException<System.IO.FileNotFoundException> (() => Files.Program.ReplaceInTheText("Test12.txt", "22", "2"));
        }
    }
}