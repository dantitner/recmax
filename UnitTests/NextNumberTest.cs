using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecMax;
namespace UnitTests
{
    [TestClass]
    public class NextNumberTest
    {
        NextNumber obj = new NextNumber();
        [TestMethod]
        public void NextNumber1()
        {
            int number = 12;
            int expected = 21;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NextNumber2()
        {
            int number = 513;
            int expected = 531;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber3()
        {
            int number = 2017;
            int expected = 2071;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber4()
        {
            int number = 414;
            int expected = 441;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber5()
        {
            int number = 144;
            int expected = 414;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber6()
        {
            int number = 1234321;
            int expected = 1241233;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber7()
        {
            int number = 1234126;
            int expected = 1234162;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber8()
        {
            int number = 3456432;
            int expected = 3462345;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber9()
        {
            int number = 10;
            int expected = -1;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextNumber10()
        {
            int number = 20;
            int expected = -1;
            int actual = obj.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
