namespace _03_CandidateConstructor
{
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }

        public UniversityEmployee (Person personValue, string taxID)
        {
            Person = personValue;
            TaxID = taxID;
        }

        public virtual string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " should respect the rights of students";
        }
    }
}

