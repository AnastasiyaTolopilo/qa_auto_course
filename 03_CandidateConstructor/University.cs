namespace _03_CandidateConstructor
{
    public class University
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

        public bool Equals(object newUniwersity)
        {
            if (newUniwersity is University university) 
            {
                bool isBuildingExist = true;

                foreach (Building newBuilding in university.Buildings)
                {
                    if (!Buildings.Contains(newBuilding)) { isBuildingExist = false; break; }
                }

                if (!isBuildingExist) { return false; }

                bool isEmployeeExist = true;

                foreach (UniversityEmployee newEmployee in university.UniversityEmployees)
                {
                    if (!UniversityEmployees.Contains(newEmployee)) { isEmployeeExist = false; break; }
                }

                if (!isEmployeeExist) { return false; }

                return university.OfficialAddress.Equals(OfficialAddress) && university.Rector.Equals(Rector);

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
