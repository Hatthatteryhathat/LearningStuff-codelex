using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("C", "Sharp", "Desktop", 1984, 5.4);
            Employee employee1 = new Employee("Python", "Snek", "The house over there", 3241, "Web-Dev");

            student1.Display();
            Console.WriteLine("-------------");
            employee1.Display();

            Console.ReadKey();
        }
    }
}
