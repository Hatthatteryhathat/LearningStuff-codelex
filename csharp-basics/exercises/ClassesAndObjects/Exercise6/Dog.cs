using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name , string sex) 
        {
            _name = name;
            _sex = sex;
        }

        public string GetFathersName() 
        {
            if (_father == null) 
            {
                return "Unknown";
            }

            return _father._name;
        }

        public void SetMother(Dog mother) 
        {
            this._mother = mother;
        }

        public void SetFather(Dog father)
        {
            this._father = father;
        }

        public bool HasSameMotherAs(Dog otherDog) 
        {
            return _mother == otherDog._mother;
        }
    }
}
