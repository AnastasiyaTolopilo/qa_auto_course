namespace _03_CandidateConstructor
{
    internal class UniversityEmployee
    {
        public Person person { get; set; }
        public string TaxID { get; set; }

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

