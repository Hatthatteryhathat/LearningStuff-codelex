using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("lear.txt");
            
            string[] lines = text.Split('\n');
            string[] words = text.Replace("\n", " ").Split(' ','\'').Where(word => word != "").ToArray();
            char[] chars = text.ToCharArray().Where(ch => ch != '\n' && ch != '\r').ToArray();

            Console.WriteLine($"Lines : {lines.Length}");
            Console.WriteLine($"Words : {words.Length}");
            Console.WriteLine($"Chars : {chars.Length}");

            Console.ReadKey();
        }
    }
}
