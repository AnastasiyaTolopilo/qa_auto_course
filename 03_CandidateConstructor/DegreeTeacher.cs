namespace _03_CandidateConstructor
{
    internal class DegreeTeacher: Teacher
    {
        public string Degree { get; set; }
        public string Rang { get; set; }
        public DegreeTeacher(Person person, int taxId, Course course, string degree, string rang): base(person, taxId, course)
        {
            Degree = degree;
            Rang = rang;
        }
        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " should teach students the next course: " + Course.Title + " on next position: " + Degree + " " + Rang;
        }
    }
}
