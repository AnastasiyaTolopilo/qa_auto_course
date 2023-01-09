namespace _03_CandidateConstructor
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Duties { get; set; }
      
        public SupportStaff(Person personValue, string taxID, string duties) : base(personValue, taxID)
        {
            Duties = duties;
        }
        public override string GetOfficialDuties()
        {
            return person.Name + " " + person.Surname + " must perform the following duties: " + Duties;
        }
    }
}
