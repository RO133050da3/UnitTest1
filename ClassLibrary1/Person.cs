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


        public Person()
        {}
        
        public Person(string name)
        {
            this.Name = name;
        }

        public bool isAdult()
        {
            return _age >= 18;
        }

    } 
}
