using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person : IEquatable<Person>
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

        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_name, other._name) && _age == other._age && string.Equals(_ssn, other._ssn);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _age.GetHashCode();
                hashCode = (hashCode*397) ^ (_ssn != null ? _ssn.GetHashCode() : 0);
                return hashCode;
            }
        }
    } 
}
