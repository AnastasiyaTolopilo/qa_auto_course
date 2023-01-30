namespace _03_CandidateConstructor
{
    public class UniversityEmployee : IComparable<UniversityEmployee>
    {
        public Person Person { get; set; }
        public int TaxId { get; set; }

        public UniversityEmployee (Person person, int taxId)
        {
            Person = person;
            CheckLenghtEmployee(person);
            TaxId = taxId;
            CheckTaxID(taxId);
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
        if (person.Name.Length + person.Surname.Length > 15) 
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
            int SumNameSurname1 = (this.Person.Name + this.Person.Surname).Length;
            int SumNameSurname2 = (compareUniversiyEmployee.Person.Name + compareUniversiyEmployee.Person.Surname).Length;

            if (SumNameSurname1 > SumNameSurname2)
                return 1;
            else
            if (SumNameSurname1 < SumNameSurname2)
                return -1;
            return 0;
         }
    }     
}
