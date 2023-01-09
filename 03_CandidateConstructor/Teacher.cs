namespace _03_CandidateConstructor
{
    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }
       
        public Teacher(Person person, string taxID, Course courseValue): base(person, taxID)
        {
            Course = courseValue;
        }

        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " should teach students the next course: " + Course.Title;
        }
    }
}
