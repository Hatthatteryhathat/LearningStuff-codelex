using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.FoodTypes;
using Hierarchy_TDD.Species;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class SpeciesTests
    {
        // Cat object
        [TestMethod]
        public void Cat_CreateACat_ShouldPosesAllThePropertiesOfACatObject()
        {
            var cat = new Cat("cat",
                "Snowball",
                "7",
                "Home",
                "Meinkun"
                );

            cat.AnimalType.Should().Be("cat");
            cat.Name.Should().Be("Snowball");
            cat.Weight.Should().Be(7);
            cat.LivingRegion.Should().Be("Home");
            cat.Breed.Should().Be("Meinkun");

            cat.Eat(new Meat("2"));
            cat.FoodEaten.Should().Be(2);

            cat.ToString().Should()
                .Be("cat |[ Snowball, Meinkun, 7kg, Home ]| Ate : 2");
        }

        // Mouse object
        [TestMethod]
        public void Mouse_CreateAMouse_ShouldPosesAllThePropertiesOfAMouseObject()
        {
            var mouse = new Mouse("mouse",
                "Snow",
                "0.4",
                "Home"
                );

            mouse.AnimalType.Should().Be("mouse");
            mouse.Name.Should().Be("Snow");
            mouse.Weight.Should().Be(0.4);
            mouse.LivingRegion.Should().Be("Home");

            mouse.Eat(new Vegetable("2"));
            mouse.FoodEaten.Should().Be(2);
        }

        // Tiger object
        [TestMethod]
        public void Tiger_CreateATiger_ShouldPosesAllThePropertiesOfATigerObject()
        {
            var tiger = new Tiger("tiger",
                "Sandball",
                "85",
                "Savanna"
            );

            tiger.AnimalType.Should().Be("tiger");
            tiger.Name.Should().Be("Sandball");
            tiger.Weight.Should().Be(85);
            tiger.LivingRegion.Should().Be("Savanna");

            tiger.Eat(new Meat("2"));
            tiger.FoodEaten.Should().Be(2);
        }

        // Zebra object
        [TestMethod]
        public void Zebra_CreateAZebra_ShouldPosesAllThePropertiesOfAZebraObject()
        {
            var zebra = new Zebra("Zebra",
                "Horsen't",
                "90.3",
                "Savana"
            );

            zebra.AnimalType.Should().Be("Zebra");
            zebra.Name.Should().Be("Horsen't");
            zebra.Weight.Should().Be(90.3);
            zebra.LivingRegion.Should().Be("Savana");

            zebra.Eat(new Vegetable("2"));
            zebra.FoodEaten.Should().Be(2);
        }
    }
}
