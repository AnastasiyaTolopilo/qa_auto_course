using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class Teacher: UniversityEmployee
    {
        public Course course { get; set; }
       
        public Teacher(Person person, string taxID, Course courseValue): base(person, taxID)
        {
            course = courseValue;
        }

        public override string GetOfficialDuties()
        {
            return person.Name + " " + person.Surname + " should teach students the next course: " + course.Title;
        }
    }
}
