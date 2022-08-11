using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class AsciiFigure
    {
        private const int PyramidSize = 5;

        public  void BuildAsciiFigure() 
        {
            int counter = 0;

            for (int i = 1; i < PyramidSize + 1; i++) 
            { 
                Console.WriteLine(new String('/', 4 * (PyramidSize - i)) + new String('*', 4 * counter) + new String('\\', 4 * (PyramidSize - i)));
                counter += 2;
            }
        }
    }
}
