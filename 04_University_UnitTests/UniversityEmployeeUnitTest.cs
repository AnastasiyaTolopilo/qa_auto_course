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
            UniversityEmployee employee1 = new(personEmployee1, "86298");

            Address addressEmployee2 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee2 = new("Natalya", "Kachan", addressEmployee2);
            UniversityEmployee employee2 = new(personEmployee2, "86298");

            Assert.IsTrue(employee1.Equals(employee2));
        }

        [TestMethod]
        public void CheckUniversityEmployeeIsEquelNegative()
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            UniversityEmployee employee1 = new(personEmployee1, "86298");

            Address addressEmployee2 = new("Minsk", "Prityckogo", 500, 11);
            Person personEmployee2 = new("Nikita", "Zybko", addressEmployee2);
            UniversityEmployee employee2 = new(personEmployee2, "11287");

            Assert.IsFalse(employee1.Equals(employee2));
        }
    }
}