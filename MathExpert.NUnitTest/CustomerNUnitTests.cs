using NUnit.Framework;

namespace MathExpert.NUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void GreetCustomer_InsertFirstNameLastName_GetGreetFullname()
        {
            //Arrage
            Customer customer = new Customer();

            //Act
            string result = customer.GreetCustomer("Angel", "Chavez");

            //Assert
            Assert.That(result, Is.EqualTo("Hello Angel Chavez"));
        }
    }
}
