namespace _03_CandidateConstructor
{
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxId { get; set; }

        public UniversityEmployee (Person person, string taxId)
        {
            Person = person;
            TaxId = taxId;
        }

        public virtual string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " should respect the rights of students";
        }
    }
}

