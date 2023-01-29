namespace _03_CandidateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addressEmployee1 = new ("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee2 = new ("Mogilew", "Kalinowskogo", 167, 45);
            Address addressEmployee3 = new ("Vitebsk", "Mira", 17, 1);
            Address addressEmployee4 = new ("Grodno", "Swobody", 78, 7);
            Address addressRector = new ("Krakow", "Powstancew", 1, 13);

            Person personEmployee1 = new ("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new ("Peter", "Byko", addressEmployee2);
            Person personEmployee3 = new ("Oleg", "Bylawski", addressEmployee3);
            Person personEmployee4 = new ("Elizaweta", "Sinica", addressEmployee4);
            Person personRector = new ("Wiacheslaw", "Gruzdow", addressRector);

            Course courseMath = new ("Mathematics", "Basics of algebra and geometry");
            Course coursePhysics = new ("Physics", "Study of the properties and phenomena of inanimate nature");

            UniversityEmployee employee = new (personEmployee1, "86298");
            Teacher teacher = new (personEmployee2, "72937", courseMath);
            DegreeTeacher degree = new (personEmployee3, "82637", coursePhysics, "Candidate of Sciences", "Professor");
            SupportStaff staff = new (personEmployee4, "13948", "Cleaner");

            List<UniversityEmployee> employees = new List<UniversityEmployee>() { employee, teacher, degree, staff };

            Room room1 = new("Lecture room");
            Room room2 = new("Laboratory room");
            Room room3 = new("Seminar room");
            Room room4 = new("Auxiliary room");
            Room room5 = new("Sports hall");

            List<Room> roomsBuilding1 = new List<Room>() { room1, room2 };
            List<Room> roomsBuilding2 = new List<Room>() { room3, room4 };
            List<Room> roomsBuilding3 = new List<Room>() { room5 };

            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Address officialAddress = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress3 = new("Minsk", "Syrganova", 15, 33);

            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);
            Building building3 = new(buidingAddress3, roomsBuilding3);

            List<Building> buildings = new List<Building>() { building1, building2 };

            University university1 = new(officialAddress, employees, buildings, personRector);

            Teacher teacher2 = new(personEmployee2, "72637", courseMath);
            university1.AddEmployee(teacher2);
            university1.AddEmployee(staff);
            university1.AddBuilding(building3);
            university1.AddEmployee(teacher);
            building3.AddRoom(room5);
            building3.AddRoom(room1);

            Room room1_alt = new("Seminar room");
            List<Room> roomsBuilding1_alt = new List<Room>() { room1_alt, room2, room3, room4 };
            Building building1_alt = new(buidingAddress2, roomsBuilding1_alt);
            Console.WriteLine(room1.Equals(room1_alt));
            Console.WriteLine(building1.Equals(building1_alt));

            Console.WriteLine("University rector is: " + university1.Rector.Name + " " + university1.Rector.Surname);    
        }
    }
}
