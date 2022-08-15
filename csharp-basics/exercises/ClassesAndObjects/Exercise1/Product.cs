using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product(string name, double priceAtStart, int amountAtStart) 
        { 
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void PrintProduct() 
        {
            Console.Write($"Name: {_name} || Price: {_price} || Amount: {_amount}");
        }

        public void ChangePrice() 
        {
            Console.Write("\nEnter new price :");
            _price = double.Parse(Console.ReadLine());
        }

        public void ChangeAmount() 
        {
            Console.Write("\nEnter new amount :");
            _amount = Int32.Parse(Console.ReadLine());
        }
    }
}
