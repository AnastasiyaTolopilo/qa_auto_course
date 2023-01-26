namespace _03_CandidateConstructor
{
    internal class University
    {
        public Address OfficialAddress { get; set; }
        public List<UniversityEmployee> UniversityEmployees { get; set; }
        public List<Building> Buildings { get; set; }
        public Person Rector { get; set; }

        public University(Address officialAddress, List<UniversityEmployee> universityEmployees, List<Building> buildings, Person rector)
        {
            OfficialAddress = officialAddress;
            UniversityEmployees = universityEmployees;
            Buildings = buildings;
            Rector = rector;
        }


        public override bool Equals(object obj)
        {
            if (obj is University)
            {
                University university = obj as University;
                return university.OfficialAddress.Equals(OfficialAddress) &&
                    university.UniversityEmployees.Equals(UniversityEmployees) &&
                    university.Buildings.Equals(Buildings) &&
                    university.Rector.Equals(Rector);
            }
            else
            {
                return false;
            }
        }
        public void AddEmployee(UniversityEmployee itemToCheck)
        {
            if(!UniversityEmployees.Contains(itemToCheck))
            {
                UniversityEmployees.Add(itemToCheck);
            }
        }
        public void AddBuilding(Building itemToCheck)
        {
            if (!Buildings.Contains(itemToCheck))
            {
                Buildings.Add(itemToCheck);
            }
        }
    }
}
