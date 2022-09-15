using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;

        public Person() {}

        public Person(string fName, string lName, string adr, int personsID)
        {
            _firstName = fName;
            _lastName = lName;
            _adress = adr;
            _id = personsID;
        }

        public virtual void Display() 
        {
            Console.WriteLine($"FirstN : {FirstName} , LastN : {LastName} , Adress : {Adress} , ID : {Id}");
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Adress => _adress;
        public int Id => _id;
    }
}
