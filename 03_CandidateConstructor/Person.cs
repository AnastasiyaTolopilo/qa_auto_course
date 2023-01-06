using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public Address address;

        public Person(string name, string surname, Address addressValue)
        {
            Name = name;
            Surname = surname;
            address = addressValue;
        }
    }
}

