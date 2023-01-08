using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class UniversityEmployee
    {
        public Person person;
        public string TaxID;

        public UniversityEmployee (Person personValue, string taxID)
        {
            person = personValue;
            TaxID = taxID;
        }

        public virtual string GetOfficialDuties()
        {
            return person.Name + " " + person.Surname + " should respect the rights of students";
        }
    }
}

