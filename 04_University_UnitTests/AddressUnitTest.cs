using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class AddressUnitTest
    {
        [TestMethod]
        public void CheckAddressIsEquelPositive()
        {
            Address addressEmployee1 = new("Minsk", "Olshevskogo", 73, 12);
            Address addressEmployee2 = new("Minsk", "Olshevskogo", 73, 12);

            Assert.IsTrue(addressEmployee1.Equals(addressEmployee2));
        }

        [TestMethod]
        public void CheckAddressIsEquelNegative()
        {
            Address addressEmployee1 = new("Minsk", "Olshevskogo", 73, 12);
            Address addressEmployee2 = new("Minsk", "Olshevskogo", 11, 11);

            Assert.IsFalse(addressEmployee1.Equals(addressEmployee2));
        }
    }
}