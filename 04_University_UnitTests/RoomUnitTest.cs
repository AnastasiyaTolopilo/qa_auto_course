using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class RoomUnitTest
    {
        [TestMethod]
        public void CheckRoomIsEquelPositive()
        {
            Room room1 = new("Seminar room", 1);
            Room room2 = new("Seminar room", 1);

            Assert.IsTrue(room1.Equals(room2));
        }

        [TestMethod]
        public void CheckRoomIsEquelNegative()
        {
            Room room1 = new("Seminar room", 1);
            Room room2 = new("Auxiliary room", 2);

            Assert.IsFalse(room1.Equals(room2));
        }
    }
}