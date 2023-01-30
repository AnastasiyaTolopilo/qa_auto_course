namespace _03_CandidateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addressEmployee1 = new("Minsk", "Prityckogo", 146, 4);
            Address addressEmployee2 = new("Mogilew", "Kalinowskogo", 167, 45);
            Address addressEmployee3 = new("Vitebsk", "Mira", 17, 1);
            Address addressEmployee4 = new("Grodno", "Swobody", 78, 7);
            Address addressRector = new("Krakow", "Powstancew", 1, 13);

            Person personEmployee1 = new("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new("Peter", "Byko", addressEmployee2);
            Person personEmployee3 = new("Oleg", "Bylawski", addressEmployee3);
            Person personEmployee4 = new("Elizaweta", "Sinica", addressEmployee4);
            Person personRector = new("Wiacheslaw", "Gruzdow", addressRector);

            Course courseMath = new("Mathematics", "Basics of algebra and geometry");
            Course coursePhysics = new("Physics", "Study of the properties and phenomena of inanimate nature");

            UniversityEmployee employee = new (personEmployee1, 86298);
            Teacher teacher = new (personEmployee2, 72937, courseMath);
            DegreeTeacher degree = new (personEmployee3, 82637, coursePhysics, "Candidate of Sciences", "Professor");
            SupportStaff staff = new (personEmployee4, 13948, "Cleaner");

            var employees = new List<UniversityEmployee>() { employee, teacher, degree, staff };

            Console.WriteLine("======== Sorted array of employees with using the CompareTo method ==============");
            UniversityEmployee[] employessArray = { employee, teacher, degree, staff };
            Array.Sort(employessArray);

            foreach (UniversityEmployee currentEmployee in employessArray)
            {
                Console.WriteLine($"{currentEmployee.Person.Name} {currentEmployee.Person.Surname}");
            }
            Console.WriteLine("=========================================================");

            Room room1 = new("Lecture room");
            Room room2 = new("Laboratory room");
            Room room3 = new("Seminar room");
            Room room4 = new("Auxiliary room");
            Room room5 = new("Sports hall");
            Room room1 = new("Lecture room", 1);
            Room room2 = new("Laboratory room", 2);
            Room room3 = new("Seminar room", 3);
            Room room4 = new("Auxiliary room", 4);
            Room room5 = new("Sports hall", 5);
            Room room6 = new("Music room", 6);

            
            var roomsBuilding1 = new List<Room>() { room1, room2, room3 };
            var roomsBuilding2 = new List<Room>() { room4, room5 };
            var roomsBuilding3 = new List<Room>() { room6 };

            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Address officialAddress = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress3 = new("Minsk", "Syrganova", 15, 33);

            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);
            Building building3 = new(buidingAddress3, roomsBuilding3);

            var buildings = new List<Building>() { building1, building2, building3 };

            University university1 = new(officialAddress, employees, buildings, personRector);

            Teacher teacher2 = new(personEmployee2, 72637, courseMath);
            university1.AddEmployee(teacher2);
            university1.AddEmployee(staff);
            university1.AddBuilding(building3);
            university1.AddEmployee(teacher);
            building3.AddRoom(room5);
            building3.AddRoom(room6);

            Room room1_alt = new("Seminar room", 3);
            var roomsBuilding1_alt = new List<Room>() { room1_alt, room2, room3, room4 };
            Building building1_alt = new(buidingAddress2, roomsBuilding1_alt);
            Console.WriteLine(room1.Equals(room1_alt));
            Console.WriteLine(building1.Equals(building1_alt));


            Console.WriteLine("University rector is: " + university1.Rector.Name + " " + university1.Rector.Surname);

            Console.WriteLine($"=============== Employees which surname starts with selected letter ======================");

            var employeeSortedBySurname = university1.UniversityEmployees
                .Where(e => e.Person.Surname.ToUpper().StartsWith("S"))
                .OrderBy(e => e.TaxId)
                .Select(o => $"{o.Person.Surname} {o.Person.Name}");

            foreach ( var employeeSorted in employeeSortedBySurname) 
            {
                Console.WriteLine(employeeSorted);
            }

            Console.WriteLine($"=============== Teacher of selected course ======================");

            var teachersSortedByCours = university1.UniversityEmployees
                .OfType<Teacher>()
                .Where(t => t.Course.Title.StartsWith("Physics"))
                .OrderBy(e => e.Person.Surname);
               
            foreach (var teacherSorted in teachersSortedByCours)
            {
                Console.WriteLine($"{teacherSorted.Person.Surname} {teacherSorted.Person.Name}");
            }

            Console.WriteLine($"=============== Tax ID and duties of employees ======================");

            var employeesWithDuties = employees
                .Select(d => $"{d.TaxId} {d.GetOfficialDuties()}");

            foreach (var employeeDuties in employeesWithDuties)
            {
                Console.WriteLine(employeeDuties);
            }

            Console.WriteLine($"============== Address of building with SELECTED number of rooms =======================");

            var selectedBuildings = university1.Buildings
                .SelectMany(b => b.Rooms, (b, r) => new { Addres = b.BuildingAddress, RoomNum = r.RoomNumber })
                .Where(obj => obj.RoomNum == 6); 

            foreach (var selectedBuilding in selectedBuildings)
            {
                Console.WriteLine(
                    $"{selectedBuilding.Addres.City} {selectedBuilding.Addres.Street}" +
                    $" {selectedBuilding.Addres.House} {selectedBuilding.Addres.Apartment}"
                );
            }

            Console.WriteLine($"============== Address of building with MAX number of rooms =======================");

            var buildingWithMaxRoomCount = buildings
                .Select(b => new { Count = b.Rooms.Count(), BuildingAddress = b.BuildingAddress })
                .MaxBy(b => b.Count);

            Console.WriteLine(
                $"{buildingWithMaxRoomCount.BuildingAddress.City} {buildingWithMaxRoomCount.BuildingAddress.Street}" +
                $" {buildingWithMaxRoomCount.BuildingAddress.House} {buildingWithMaxRoomCount.BuildingAddress.Apartment}"
            );

            Console.WriteLine($"=============== Print surname with max usages ======================");

            var maxSurnameUsages = university1.UniversityEmployees
                .GroupBy(currEmp => currEmp.Person.Surname)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .MaxBy(b => b.Count);

            Console.WriteLine($"{maxSurnameUsages?.Name} : {maxSurnameUsages?.Count} ");
        }
    }
}
