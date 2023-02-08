using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void CheckAPersonIsEquelPositive()
        {
            Address addressEmployee1 = new("Grodno", "Swobody", 78, 7);
            Person personEmployee1 = new("Oleg", "Bylawski", addressEmployee1);

            Address addressEmployee2 = new("Grodno", "Swobody", 78, 7);
            Person personEmployee2 = new("Oleg", "Bylawski", addressEmployee2);

            Assert.IsTrue(personEmployee1.Equals(personEmployee2));
        }

        [TestMethod]
        public void CheckPersonIsEquelNegative()
        {
            Address addressEmployee1 = new("Grodno", "Swobody", 78, 7);
            Person personEmployee1 = new("Oleg", "Bylawski", addressEmployee1);

            Address addressEmployee2 = new("Mogilew", "Kalinowskogo", 167, 45);
            Person personEmployee2 = new("Elizaweta", "Sinica", addressEmployee2);

            Assert.IsFalse(personEmployee1.Equals(personEmployee2));
        }
    }
}