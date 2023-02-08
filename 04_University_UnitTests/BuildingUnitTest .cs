using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class BuildingUnitTest
    {
        [TestMethod]
        public void CheckBuildingIsEquelPositive()
        {

            Room room1 = new("Seminar room", 1);
            Room room2 = new("Laboratory room", 2);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 18, 2);
            Building building1 = new(buidingAddress1, roomsBuilding1);

            Room room3 = new("Seminar room", 1);
            Room room4 = new("Laboratory room", 2);
            var roomsBuilding2 = new List<Room>() { room3, room4 };
            Address buidingAddress2 = new("Minsk", "Nezawisimosti", 18, 2);
            Building building2 = new(buidingAddress2, roomsBuilding2);

            Assert.IsTrue(building1.Equals(building2));
        }

        [TestMethod]
        public void CheckBuildingIsEquelNegative()
        {
            Room room1 = new("Seminar room", 1);
            Room room2 = new("Laboratory room", 2);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 18, 2);
            Building building1 = new(buidingAddress1, roomsBuilding1);

            Room room3 = new("Seminar room", 10);
            Room room4 = new("Laboratory room", 20);
            var roomsBuilding2 = new List<Room>() { room3, room4 };
            Address buidingAddress2 = new("Minsk", "Nezawisimosti", 180, 20);
            Building building2 = new(buidingAddress2, roomsBuilding2);

            Assert.IsFalse(building1.Equals(building2));
        }

        [TestMethod]
        public void CheckAddRoomIsEquelPositive()
        {
            Room room1 = new("Seminar room", 1);
            Room room2 = new("Laboratory room", 2);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 18, 2);
            Building building1 = new(buidingAddress1, roomsBuilding1);

            Room room3 = new("Music room", 3);
            building1.AddRoom(room3);

            Assert.AreEqual(3, building1.Rooms.Count());
        }

        [TestMethod]
        public void CheckAddRoomIsEquelNegative()
        {
            Room room1 = new("Seminar room", 1);
            Room room2 = new("Laboratory room", 2);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 18, 2);
            Building building1 = new(buidingAddress1, roomsBuilding1);

            building1.AddRoom(room1);

            Assert.AreNotEqual(3, building1.Rooms.Count());
        }
    }
}