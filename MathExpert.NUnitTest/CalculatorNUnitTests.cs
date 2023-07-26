using NUnit.Framework;
using System.Security.Cryptography;

namespace MathExpert.NUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void Sum_InsertTwoNumbers_GetSum()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Sum(10, 5);

            //Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void IsOdd_InsertNumber_GetFalse()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.IsOdd(12);

            //Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOdd_InsertNumber_GetTrue(int num)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.IsOdd(num);

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOdd_InsertNumber_GetTrueOrFalse(int num)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.IsOdd(num);

            //Assert
            return result;
        }

        [Test]
        [TestCase(10.5, 1.4)] //5.0
        [TestCase(10.5, 1.5)] //12.0
        public void SumDouble_InsertTwoNumbers_GetSum(double x, double y)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double result = calculator.SumDouble(x, y);

            //Assert
            Assert.AreEqual(12.0, result, 1); //12.0 + 1 = 13.0
        }

        [Test]
        public void GetOddRanks_InsertStartEnd_GetOddList()
        {
            //Arrange
            Calculator calculator = new Calculator();
            
            //Act
            List<int> listOfExpectedOddNumbers = new() { 3, 5, 7 };
            List<int> result = calculator.GetOddRanks(3, 8);

            //Assert
            Assert.That(result, Is.EquivalentTo(listOfExpectedOddNumbers));
        }
    }
}
