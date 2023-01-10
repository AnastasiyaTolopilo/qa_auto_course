﻿namespace _03_CandidateConstructor
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Duties { get; set; }
      
        public SupportStaff(Person person, string taxID, string duties) : base(person, taxID)
        {
            Duties = duties;
        }
        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.Surname + " must perform the following duties: " + Duties;
        }
    }
}