namespace _03_CandidateConstructor
{
    internal class University
    {
        public Address OfficialAddress { get; set; }
        public UniversityEmployee[] UniversityEmployees { get; set; }
        public Building[] Buildings { get; set; }
        public Person Rector { get; set; }

        public University(Address officialAddressValue, UniversityEmployee[] universityEmployeesValue, Building[] buildingsValue, Person rector)
        {
            OfficialAddress = officialAddressValue;
            UniversityEmployees = universityEmployeesValue;
            Buildings = buildingsValue;
            Rector = rector;
        }
    }
}
