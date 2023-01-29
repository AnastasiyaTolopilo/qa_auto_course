using _03_CandidateConstructor;

namespace _04_University_UnitTests
{
    [TestClass]
    public class UniversityUnitTest
    {
        [TestMethod]
        public void CheckUniversityIsEquelPositive()
        {
            Address officialAddress = new("Minsk", "Nezawisimosti", 170, 7);
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee2 = new("Mogilew", "Kalinowskogo", 167, 45);
            Address addressRector = new("Krakow", "Powstancew", 1, 13);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new("Peter", "Byko", addressEmployee2);
            Course courseMath = new("Mathematics", "Basics of algebra and geometry");
            UniversityEmployee employee = new(personEmployee1, "86298");
            Teacher teacher = new(personEmployee2, "72937", courseMath);
            var employees = new List<UniversityEmployee>() { employee, teacher };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Room room1 = new("Lecture room", 1);
            Room room2 = new("Laboratory room", 2);
            Room room3 = new("Seminar room", 3);
            Room room4 = new("Auxiliary room", 4);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            var roomsBuilding2 = new List<Room>() { room3, room4 };
            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);
            var buildings = new List<Building>() { building1, building2 };
            Person personRector = new("Wiacheslaw", "Gruzdow", addressRector);

            University university1 = new(officialAddress, employees, buildings, personRector);


            Address officialAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address addressEmployee11 = new("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee21 = new("Mogilew", "Kalinowskogo", 167, 45);
            Address addressRector1 = new("Krakow", "Powstancew", 1, 13);
            Person personEmployee11 = new("Natalya", "Kachan", addressEmployee11);
            Person personEmployee21 = new("Peter", "Byko", addressEmployee21);
            Course courseMath1 = new("Mathematics", "Basics of algebra and geometry");
            UniversityEmployee employee1 = new(personEmployee11, "86298");
            Teacher teacher1 = new(personEmployee21, "72937", courseMath1);
            var employees1 = new List<UniversityEmployee>() { employee1, teacher1 };
            Address buidingAddress11 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress21 = new("Minsk", "Pobeditelei", 208, 13);
            Room room11 = new("Lecture room", 1);
            Room room21 = new("Laboratory room", 2);
            Room room31 = new("Seminar room", 3);
            Room room41 = new("Auxiliary room", 4);
            var roomsBuilding11 = new List<Room>() { room11, room21 };
            var roomsBuilding21 = new List<Room>() { room31, room41 };
            Building building11 = new(buidingAddress11, roomsBuilding11);
            Building building21 = new(buidingAddress21, roomsBuilding21);
            var buildings1 = new List<Building>() { building11, building21 };
            Person personRector1 = new("Wiacheslaw", "Gruzdow", addressRector1);

            University university2 = new(officialAddress1, employees1, buildings1, personRector1);

            Assert.IsTrue(university1.Equals(university2));
        }

        [TestMethod]
        public void CheckUniversityIsEquelNegative()
        {
            Address officialAddress = new("Minsk", "Nezawisimosti", 170, 7);
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee2 = new("Mogilew", "Kalinowskogo", 167, 45);
            Address addressRector = new("Krakow", "Powstancew", 1, 13);
            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new("Peter", "Byko", addressEmployee2);
            Course courseMath = new("Mathematics", "Basics of algebra and geometry");
            UniversityEmployee employee = new(personEmployee1, "86298");
            Teacher teacher = new(personEmployee2, "72937", courseMath);
            var employees = new List<UniversityEmployee>() { employee, teacher };
            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Room room1 = new("Lecture room", 1);
            Room room2 = new("Laboratory room", 2);
            Room room3 = new("Seminar room", 3);
            Room room4 = new("Auxiliary room", 4);
            var roomsBuilding1 = new List<Room>() { room1, room2 };
            var roomsBuilding2 = new List<Room>() { room3, room4 };
            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);
            var buildings = new List<Building>() { building1, building2 };
            Person personRector = new("Wiacheslaw", "Gruzdow", addressRector);

            University university1 = new(officialAddress, employees, buildings, personRector);


            Address officialAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address addressEmployee11 = new("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee21 = new("Mogilew", "Kalinowskogo", 167, 45);
            Address addressRector1 = new("Krakow", "Powstancew", 1, 13);
            Person personEmployee11 = new("Natalya", "Kachan", addressEmployee11);
            Person personEmployee21 = new("Peter", "Byko", addressEmployee21);
            Course courseMath1 = new("Mathematics", "Basics of algebra and geometry");
            UniversityEmployee employee1 = new(personEmployee11, "86298");
            Teacher teacher1 = new(personEmployee21, "72937", courseMath1);
            var employees1 = new List<UniversityEmployee>() { employee1, teacher1 };
            Address buidingAddress11 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress21 = new("Minsk", "Pobeditelei", 208, 13);
            Room room11 = new("Lecture room", 1);
            Room room21 = new("Laboratory room", 2);
            Room room31 = new("Seminar room", 3);
            Room room41 = new("Auxiliary room", 4);
            var roomsBuilding11 = new List<Room>() { room11, room21 };
            var roomsBuilding21 = new List<Room>() { room31, room41 };
            Building building11 = new(buidingAddress11, roomsBuilding11);
            Building building21 = new(buidingAddress21, roomsBuilding21);
            var buildings1 = new List<Building>() { building11, building21 };
            Person personRector1 = new("Ekaterina", "Gruzdowa", addressRector);

            University university2 = new(officialAddress1, employees1, buildings1, personRector1);

            Assert.IsFalse(university1.Equals(university2));
        }
    }
}