using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person 
    {
        private string _name;
        private decimal _age;
        private string _ssn; // Social Security Number
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _name = value;
            }
        }

        public decimal Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public Person()
        {}

        public Person(string ssn, string name)
        {
            this.SSN = ssn;
            this.Name = name;
        }
        
        public Person(string ssn)
        {
            this.SSN = ssn;
        }

        public bool isAdult()
        {
            return _age >= 18;
        }


        public override bool Equals(object obj)
        {
           

            Person other = (Person) obj;

            if (this.Name != other.Name)
            {
                return false;
            }
            if (this.Age != other.Age)
            {
                return false;
            }

            return true;
        }
    } 
}
