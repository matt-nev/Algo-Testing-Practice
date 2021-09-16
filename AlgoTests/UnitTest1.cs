using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoPractice;

namespace AlgoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var sut = new ReverseText();

            //Act
            var expected = "ecar taerG";
            var actual = sut.Reverse();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var sut = new ReverseText();
            var input = "a man a plan a canal panama";

            //Act
            var expected = true;
            var actual = sut.Palindrome(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }


}
