namespace _03_CandidateConstructor
{
    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }
       
        public Teacher(Person person, string taxId, Course course): base(person, taxId)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " should teach students the next course: " + Course.Title;
        }
    }
}
