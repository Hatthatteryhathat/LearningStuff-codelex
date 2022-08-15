using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> ProductList = new List<Product>();

            ProductList.Add( new Product("Logitech mouse", 70.00 , 14) );
            ProductList.Add( new Product("iPhone 5s", 999.99 , 3) );
            ProductList.Add( new Product("Epson EB-U05", 440.46 , 1) );

            while (true) 
            {
                Console.Clear();
                Console.Write("1|| ");
                ProductList[0].PrintProduct();
                Console.Write("\n----------------\n");
                Console.Write("2|| ");
                ProductList[1].PrintProduct();
                Console.Write("\n----------------\n");
                Console.Write("3|| ");
                ProductList[2].PrintProduct();
                Console.Write("\n----------------\n");
                Console.WriteLine("-=-=-=-=-=-=-=-");

                Console.Write("Choose product to edit : ");
                int chosenProduct = (int)char.GetNumericValue(Console.ReadKey().KeyChar);

                Console.Write("\n1. Change Price \n2. Change Amount \n-------");
                Console.Write("\n1 or 2 : ");
                int chosenAction = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
                
                if (chosenAction == 1)
                {
                    ProductList[chosenProduct - 1].ChangePrice();
                }
                else if (chosenAction == 2) 
                { 
                    ProductList[chosenProduct - 1].ChangeAmount();
                }
            }
        }
    }
}
