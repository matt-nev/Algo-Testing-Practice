using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class DoubleCheckerTesting
    {
        [TestMethod]
        public void DoubleCheckerTest()
        {       
            //Arrange
            DoubleChecker sut = new DoubleChecker();
            int[] input = { 22, 1, 7, 11 };

            //Act
            bool expected = true;
            bool actual = sut.IsDouble(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
