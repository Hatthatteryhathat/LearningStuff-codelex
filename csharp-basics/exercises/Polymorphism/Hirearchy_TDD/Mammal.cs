namespace Hierarchy_TDD
{
    public abstract class Mammal : Animal
    {
        public abstract string LivingRegion { get; }
        public override string ToString()
        {
            return $"{AnimalType} |[ {Name} , {Weight}kg, {LivingRegion} ]| Ate : {FoodEaten}";
        }
    }
}