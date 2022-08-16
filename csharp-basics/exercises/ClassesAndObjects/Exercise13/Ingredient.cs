using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Ingredient
    {
        private string _name;
        private double _cost;

        public Ingredient(string name, double cost) 
        { 
            _name = name;
            _cost = cost;
        }

        public string Name => _name;

        public double Cost => _cost;
    }
}
