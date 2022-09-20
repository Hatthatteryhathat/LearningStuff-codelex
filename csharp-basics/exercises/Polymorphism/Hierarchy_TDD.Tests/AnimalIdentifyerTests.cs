using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class AnimalIdentifyerTests
    {
        [TestMethod]
        public void IdentifyAnimal_PassInInfo_CreateNewAnimal()
        {
            var inputArr = "Zebra testZebra 100 Savanna".Split(" ");

            var zebra = AnimalIdentifyer.IdentifyAnimal(inputArr);

            zebra.AnimalType.Should().Be("Zebra");
            zebra.Name.Should().Be("testZebra");
            zebra.Weight.Should().Be(100);
        }
    }
}
