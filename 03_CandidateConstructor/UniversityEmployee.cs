namespace _03_CandidateConstructor
{
    public class UniversityEmployee : IComparable<UniversityEmployee>
    {
        public Person Person { get; set; }
        public int TaxId { get; set; }

        public UniversityEmployee (Person person, int taxId)
        {
            CheckLenghtEmployee(person);
            CheckTaxID(taxId);

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

        private void CheckLenghtEmployee(Person person)
        {
        if ((person?.FullNameLenght() ?? 0) > 15) 
            {
                throw new ArgumentException("The length of the first and last name exceeds the allowed number of characters");
            }
        }

        private void CheckTaxID(int taxId) 
        {
            if (taxId < 0)
            {
                throw new ArgumentException("TaxID entered incorrectly");
            }
        }

        public int CompareTo(UniversityEmployee compareUniversiyEmployee)
        {
            int SumNameSurname1 = Person.FullNameLenght();
            int SumNameSurname2 = compareUniversiyEmployee.Person.FullNameLenght();

            return SumNameSurname1 - SumNameSurname2;
         }
    }
}
