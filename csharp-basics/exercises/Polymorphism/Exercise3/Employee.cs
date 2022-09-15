using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Employee : Person
    {
        private string _jobTitle;

        public Employee(string fName, string lName, string adr, int personsID, string jobTitle)
            : base(fName, lName, adr, personsID)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"FirstN : {FirstName} , LastN : {LastName} , Adress : {Adress} , ID : {Id} , jobTitle : {JobTitle}");
        }

        public string JobTitle => _jobTitle;
    }
}
