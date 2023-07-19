namespace MathExpert.MSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void Sum_InsertTwoNumbers_GetSum()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Ac
            int result = calculator.Sum(15, 35);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}
