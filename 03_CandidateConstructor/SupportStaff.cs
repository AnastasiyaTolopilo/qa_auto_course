﻿namespace _03_CandidateConstructor
{
    public class SupportStaff: UniversityEmployee
    {
        public string Duties { get; set; }
      
        public SupportStaff(Person person, int taxID, string duties) : base(person, taxID)
        {
            Duties = duties;
        }
        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " must perform the following duties: " + Duties;
        }
    }
}
