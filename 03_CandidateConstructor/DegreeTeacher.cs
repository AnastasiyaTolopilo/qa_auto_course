using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class DegreeTeacher: Teacher
    {
        public string Degree;
        public string Rang;
        public DegreeTeacher(Person personValue, string taxID, Course courseValue, string degree, string rang): base(personValue, taxID, courseValue)
        {
            Degree = degree;
            Rang = rang;
        }
        public override string GetOfficialDuties()
        {
            return person.Name + " " + person.Surname + " should teach students the next course: " + course.Title + " on next position: " + Degree + " " + Rang;
        }
    }
}
