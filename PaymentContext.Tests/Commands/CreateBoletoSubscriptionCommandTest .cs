using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTest
    {
        [TestMethod]
        public void ShouldReturnErrorWhenIsValid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();

            Assert.AreEqual(false, command.IsValid);
        }
    }
}
