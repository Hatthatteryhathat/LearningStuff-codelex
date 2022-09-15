namespace Hierarchy_TDD.FoodTypes
{
    public class Meat : Food
    {
        private int _quantity;

        public Meat(string quantity)
        {
            _quantity = int.Parse(quantity);
        }

        public override int FoodQuantity => _quantity;
    }
}