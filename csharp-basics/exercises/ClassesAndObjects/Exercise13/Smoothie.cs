using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Smoothie
    {
        private List<Ingredient> _ingredientList = new List<Ingredient>();
        private List<string> _ingredientNames = new List<string>();

        public Smoothie(Ingredient[] list) 
        {
            for (int i = 0; i < list.Length; i++) 
            {
                _ingredientList.Add(list[i]);
                _ingredientNames.Add(list[i].Name);
            }
        }

        public string GetName() 
        {
            string name = "";
            foreach (Ingredient i in _ingredientList)
            {
                name += i.Name + ", ";
            }

            if (_ingredientList.Count > 1)
            {
                name += "Fusion!";
            }
            else 
            { 
                name += "Smoothie!";
            }

            return name;
        }

        public double GetCost() 
        {
            double sum = 0;

            foreach (Ingredient i in _ingredientList) 
            {
                sum += i.Cost;
            }

            return sum;
        }

        public double GetPrice()
        {
            return Math.Round(GetCost() * 1.5 , 2);
        }

        public List<string> Ingredients => _ingredientNames;
    }
}
