using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.Species;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class FeedAnimalTests
    {
        [TestMethod]
        public void Feed_FeedZebra_ZebraFoodEatenShouldChange()
        {
            var zebra = new Zebra("Zebra", "testZebra", "100", "Savanna");
            var input = "Vegetable 1".Split(" ");

            FeedAnimal.Feed(zebra,input);

            zebra.FoodEaten.Should().Be(1);
        }
    }
}
