using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Bluu");
            colors.Add("Red");
            colors.Add("Transparrent");
            colors.Add("Pink");
            colors.Add("Black");

            Console.WriteLine(string.Join(", ", colors));

            Console.ReadKey();
        }
    }
}
