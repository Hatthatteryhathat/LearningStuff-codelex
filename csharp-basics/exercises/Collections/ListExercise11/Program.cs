using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            colors.Add("Purple");
            colors.Add("Rainbow");
            colors.Add("Aqua");
            colors.Add("Brown");
            colors.Add("Yellow");

            colors.Insert(4, "Turquise");

            int count = 0;
            foreach (string color in colors) 
            { 
                count++;
            }

            colors[count - 1] = "YellowerYellow";

            colors.Sort();

            Console.WriteLine($"List contains 'Foobar' : {colors.Exists(color => color == "Foobar")}");

            for (int i = 0; i < colors.Count; i++) 
            {
                Console.WriteLine(colors[i]);
            }

            Console.ReadKey();
        }
    }
}
