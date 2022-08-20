using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> listyArray = new List<string>(array);

            HashSet<string> settyList = new HashSet<string>(array);

            Dictionary<string, string> dList = new Dictionary<string, string> 
            {
                {"Audi", "Germany"},
                {"BWM", "Germany"},
                {"Honda", "Japan"},
                {"Mercedes", "Germany"},
                {"VolksWagen", "Germany"},
                {"Tesla", "USA"},
            };
        }
    }
}
