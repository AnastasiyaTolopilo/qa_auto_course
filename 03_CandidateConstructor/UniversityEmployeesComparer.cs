namespace _03_CandidateConstructor
{
    internal class UniversityEmployeesComparer : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee? employee1, UniversityEmployee? employee2)
        {
            int employee1Lenght = (employee1?.Person.Name + employee1?.Person.Surname)?.Length ?? 0;
            int employee2Lenght = (employee2?.Person.Name + employee2?.Person.Surname)?.Length ?? 0;
            return employee2Lenght - employee1Lenght;
        }
    }
}
