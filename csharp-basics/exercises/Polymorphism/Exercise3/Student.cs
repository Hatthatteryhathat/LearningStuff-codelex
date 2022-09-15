using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Student : Person
    {
        private double _GPA;

        public Student(double gPA)
        {
            _GPA = gPA;
        }

        public Student(string fName, string lName, string adr, int personsID, double GPA)
            : base(fName, lName, adr, personsID)
        {
            _GPA = GPA;
        }

        public override void Display() 
        {
            Console.WriteLine($"FirstN : {FirstName} , LastN : {LastName} , Adress : {Adress} , ID : {Id} , GPA : {GPA}");
        }

        public double GPA => _GPA;
    }
}
