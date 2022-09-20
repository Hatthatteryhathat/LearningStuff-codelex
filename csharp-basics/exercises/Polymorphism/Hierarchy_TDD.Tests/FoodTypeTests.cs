using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.FoodTypes;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class FoodTypeTests
    {
        [TestMethod]
        public void FoodTypes_CreateMeatObject_ReturnMeatQuantity()
        {
            var meat = new Meat("2");
            meat.FoodQuantity.Should().Be(2);
        }

        [TestMethod]
        public void FoodTypes_CreateVegetableObject_ReturVegetableQuantity()
        {
            var vegetable = new Vegetable("2");
            vegetable.FoodQuantity.Should().Be(2);
        }
    }
}
