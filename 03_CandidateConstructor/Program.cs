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

            UniversityEmployee[] employees = { employee, teacher, degree, staff };

            Room room1 = new("Lecture room");
            Room room2 = new("Laboratory room");
            Room room3 = new("Seminar room");
            Room room4 = new("Auxiliary room");

            Room[] roomsBuilding1 = { room1, room2 };
            Room[] roomsBuilding2 = { room3, room4 };

            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Address officialAddressValue = new("Minsk", "Nezawisimosti", 170, 7);

            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);

            Building[] buildings = { building1, building2 };

            University university1 = new(officialAddressValue, employees, buildings, personRector);

            Console.WriteLine("University rector is: " + university1.Rector.Name + " " + university1.Rector.Surname);
        }
    }
}

