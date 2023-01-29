namespace _03_CandidateConstructor
{
    public class UniversityEmployee
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

        public override bool Equals(object obj)
        {
            return obj is UniversityEmployee employee
                && employee.TaxId.Equals(TaxId);
        }
    }     
}
