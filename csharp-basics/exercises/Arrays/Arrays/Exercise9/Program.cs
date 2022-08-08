using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"samuel", "MABELLE", "letitia", "mErIDith"};
            Console.WriteLine("Before : " + string.Join(", ", names));

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                name = name.ToLower();
                names[i] = char.ToUpper(name[0]) + name.Substring(1,name.Length - 1);
            }

            Console.WriteLine("After : " + string.Join(", ", names));
            Console.ReadKey();
        }
    }
}
