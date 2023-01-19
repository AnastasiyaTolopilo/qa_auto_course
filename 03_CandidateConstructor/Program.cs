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

            UniversityEmployee employee = new(personEmployee1, "86298");
            Teacher teacher = new(personEmployee2, "72937", courseMath);
            DegreeTeacher degree = new(personEmployee3, "82637", coursePhysics, "Candidate of Sciences", "Professor");
            SupportStaff staff = new(personEmployee4, "13948", "Cleaner");

            List<UniversityEmployee> employees = new List<UniversityEmployee>() { employee, teacher, degree, staff };

            Room room1 = new("Lecture room", 1);
            Room room2 = new("Laboratory room", 2);
            Room room3 = new("Seminar room", 3);
            Room room4 = new("Auxiliary room", 4);
            Room room5 = new("Sports hall", 5);
            Room room6 = new("Music room", 6);

            List<Room> roomsBuilding1 = new List<Room>() { room1, room2, room3 };
            List<Room> roomsBuilding2 = new List<Room>() { room4, room5 };
            List<Room> roomsBuilding3 = new List<Room>() { room6 };

            Address buidingAddress1 = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress2 = new("Minsk", "Pobeditelei", 208, 13);
            Address officialAddress = new("Minsk", "Nezawisimosti", 170, 7);
            Address buidingAddress3 = new("Minsk", "Syrganova", 15, 33);

            Building building1 = new(buidingAddress1, roomsBuilding1);
            Building building2 = new(buidingAddress2, roomsBuilding2);
            Building building3 = new(buidingAddress3, roomsBuilding3);

            List<Building> buildings = new List<Building>() { building1, building2, building3 };

            University university1 = new(officialAddress, employees, buildings, personRector);

            Teacher teacher2 = new(personEmployee2, "12637", courseMath);
            university1.AddEmployee(teacher2);
            university1.AddEmployee(staff);
            university1.AddBuilding(building3);
            university1.AddEmployee(teacher);
            building3.AddRoom(room5);
            building3.AddRoom(room6);

            Console.WriteLine("University rector is: " + university1.Rector.Name + " " + university1.Rector.Surname);

            Console.WriteLine($"=============== Employees which surname starts with selected letter ======================");

            UniversityEmployee employeeSortedBySurname = employees.Where(e => e.Person.Surname.ToUpper().StartsWith("S")).OrderBy(e => e.TaxId);

            foreach (UniversityEmployee employeeSorted in employeeSortedBySurname)
            {
                Console.WriteLine($"{employeeSorted.Person.Surname} {employeeSorted.Person.Name}");
            }

            Console.WriteLine($"=============== Teacher of selected course ======================");
    
            List<Teacher> teachers = new List<Teacher>() { teacher, degree, teacher2 };
            var teachersSortedByCours = teachers.Where(t => t.Course.Title.StartsWith("Physics")).OrderBy(e => e.Person.Surname);
            
            foreach (Teacher teacherSorted in teachersSortedByCours)
            {
                Console.WriteLine($"{teacherSorted.Person.Surname} {teacherSorted.Person.Name}");
            }

            Console.WriteLine($"=============== Tax ID and duties of employees ======================");

            var employeesWithDuties = employees.Select(d => new
            {
                TaxId = d.TaxId,
                Duties = d.GetOfficialDuties(),
            });

            foreach (var employeeDuties in employeesWithDuties)
            {
                Console.WriteLine($"{employeeDuties.TaxId} {employeeDuties.Duties}");
            }

            Console.WriteLine($"============== Address of building with SELECTED number of rooms =======================");

            var selectedBuildings = from building in buildings
                                    from room in building.Rooms
                                    where room.RoomNumber == 6
                                    select building;

            foreach (var selectedBuilding in selectedBuildings)
            {
                Console.WriteLine(
                    $"{selectedBuilding.BuildingAddress.City} {selectedBuilding.BuildingAddress.Street}" +
                    $" {selectedBuilding.BuildingAddress.House} {selectedBuilding.BuildingAddress.Apartment}"
                );
            }

            Console.WriteLine($"============== Address of building with MAX number of rooms =======================");

            var buildingRoomsCount = buildings.Select(b => new
            {
                Count = b.Rooms.Count(),
                BuildingAddress = b.BuildingAddress
            });

            var buildingWithMaxRoomCount = buildingRoomsCount.MaxBy(b => b.Count);

            Console.WriteLine(
                $"{buildingWithMaxRoomCount.BuildingAddress.City} {buildingWithMaxRoomCount.BuildingAddress.Street}" +
                $" {buildingWithMaxRoomCount.BuildingAddress.House} {buildingWithMaxRoomCount.BuildingAddress.Apartment}"
            );

            Console.WriteLine($"=============== Print surname with max usages ======================");

            var personsSurnames = from currentEmployee in employees
                                 group currentEmployee by currentEmployee.Person.Surname into g
                                 select new { Name = g.Key, Count = g.Count() };

            var maxSurnameUsages = personsSurnames.MaxBy(b => b.Count);
            Console.WriteLine($"{maxSurnameUsages.Name} : {maxSurnameUsages.Count} ");
        }
    }
}
