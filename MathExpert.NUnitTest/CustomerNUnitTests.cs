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
            Assert.AreEqual(result, "Hello Angel Chavez");
            Assert.That(result, Is.EqualTo("Hello Angel Chavez"));
            Assert.That(result, Does.Contain("Hello"));
            Assert.That(result, Does.StartWith("Hello"));
            Assert.That(result, Does.EndWith("Chavez"));
            Assert.That(result, Does.Match("Hello [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }
    }
}
