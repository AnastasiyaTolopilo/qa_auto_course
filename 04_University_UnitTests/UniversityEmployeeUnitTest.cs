using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class UniversityEmployeeUnitTest
    {
        [TestMethod]
        public void CheckIsUniversityEmployeeEquelPositive()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            UniversityEmployee employee1 = new(personEmployee1, 86298);

            Address addressEmployee2 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee2 = new("Natalya", "Kachan", addressEmployee2);
            UniversityEmployee employee2 = new(personEmployee2, 86298);

            Assert.IsTrue(employee1.Equals(employee2));
        }

        [TestMethod]
        public void CheckUniversityEmployeeIsEquelNegative()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            UniversityEmployee employee1 = new(personEmployee1, 86298);

            Address addressEmployee2 = new("Minsk", "Prityckogo", 500, 11);
            Person personEmployee2 = new("Nikita", "Zybko", addressEmployee2);
            UniversityEmployee employee2 = new(personEmployee2, 11287);

            Assert.IsFalse(employee1.Equals(employee2));
        }

        [TestMethod]
        public void CheckUniversityEmployeeTaxIdThrowExceptionlNegative()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);

            var exception = Assert.ThrowsException<ArgumentException>(() => new UniversityEmployee(personEmployee1, -86298));

            Assert.AreEqual("TaxID entered incorrectly", exception.Message);
        }

        [TestMethod]
        public void CheckUniversityEmployeeLenghtNameSurnameThrowExceptionlNegative()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachannova", addressEmployee1);

            var exception = Assert.ThrowsException<ArgumentException>(() => new UniversityEmployee(personEmployee1, 86298));

            Assert.AreEqual("The length of the first and last name exceeds the allowed number of characters", exception.Message);
        }

        [TestMethod]
        public void CheckIsUniversityEmployeeSortByComparablePositive()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);         //3
            UniversityEmployee employee1 = new(personEmployee1, 86298);

            Address addressEmployee2 = new("Minsk", "Prityckogo", 500, 11);
            Person personEmployee2 = new("Nikita", "Zybko", addressEmployee2);           //1
            UniversityEmployee employee2 = new(personEmployee2, 11287);

            Address addressEmployee3 = new("Minsk", "Olshewskogo", 4, 2);
            Person personEmployee3 = new("Oleg", "Bylawski", addressEmployee3);          //2
            UniversityEmployee employee3 = new(personEmployee3, 72910);

            UniversityEmployee[] employessArray = { employee1, employee2, employee3 };
            Array.Sort(employessArray);
            Assert.AreEqual(employessArray[0], employee2);
        }

        [TestMethod]
        public void CheckIsUniversityEmployeeSortIComparerPositive()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);         //3
            UniversityEmployee employee1 = new(personEmployee1, 86298);

            Address addressEmployee2 = new("Minsk", "Prityckogo", 500, 11);
            Person personEmployee2 = new("Nikita", "Zybko", addressEmployee2);           //1
            UniversityEmployee employee2 = new(personEmployee2, 11287);

            Address addressEmployee3 = new("Minsk", "Olshewskogo", 4, 2);
            Person personEmployee3 = new("Oleg", "Bylawski", addressEmployee3);          //2
            UniversityEmployee employee3 = new(personEmployee3, 72910);

            var employees = new List<UniversityEmployee>() { employee1, employee2, employee3 };
            var sortedEmployees = employees.OrderBy(p => p, new UniversityEmployeesComparer());
            Assert.AreEqual(sortedEmployees.ToList()[0], employee1);
        }

        [TestMethod]
        public void CheckIsUniversityEmployeeSortByLinqOrderByPositive()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);         //3
            UniversityEmployee employee1 = new(personEmployee1, 86298);

            Address addressEmployee2 = new("Minsk", "Prityckogo", 500, 11);
            Person personEmployee2 = new("Nikita", "Zybko", addressEmployee2);           //1
            UniversityEmployee employee2 = new(personEmployee2, 11287);

            Address addressEmployee3 = new("Minsk", "Olshewskogo", 4, 2);
            Person personEmployee3 = new("Oleg", "Bylawski", addressEmployee3);          //2
            UniversityEmployee employee3 = new(personEmployee3, 72910);

            var employees = new List<UniversityEmployee>() { employee1, employee2, employee3 };
            var employeeSortedByLINQ = employees
                .OrderBy(e => (e.Person.Name + e.Person.Surname).Length);
            Assert.AreEqual(employeeSortedByLINQ.ToList()[0], employee2);
        }
    }
}