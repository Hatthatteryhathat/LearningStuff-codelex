using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine_TDD;

namespace VendingMachine_TDD.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Money_CreateMoney_MoneyCreated()
        {
            var money = new MoneyObj.Money();

            money.Euros = 10;
            money.Cents = 10;

            money.Euros.Should().Be(10);
            money.Cents.Should().Be(10);
        }
    }
}
