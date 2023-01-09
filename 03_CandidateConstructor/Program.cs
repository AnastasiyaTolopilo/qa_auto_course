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

            Person personEmployee1 = new ("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new ("Peter", "Byko", addressEmployee2);
            Person personEmployee3 = new ("Oleg", "Bylawski", addressEmployee3);
            Person personEmployee4 = new ("Elizaweta", "Sinica", addressEmployee4);

            Course courseMath = new ("Mathematics", "Basics of algebra and geometry");
            Course coursePhysics = new ("Physics", "Study of the properties and phenomena of inanimate nature");

            UniversityEmployee employee = new (personEmployee1, "86298");
            Teacher teacher = new (personEmployee2, "72937", courseMath);
            DegreeTeacher degree = new (personEmployee3, "82637", coursePhysics, "Candidate of Sciences", "Professor");
            SupportStaff staff = new (personEmployee4, "13948", "Cleaner");

            UniversityEmployee[] employees = { employee, teacher, degree, staff };

            foreach (UniversityEmployee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.GetOfficialDuties());
            }

            foreach (UniversityEmployee currentEmployee in employees)
            {
                if (currentEmployee is Teacher)
                {
                    Console.WriteLine(
                        currentEmployee.Person.Name + " " + currentEmployee.Person.Surname + " is a teacher"
                    );
                }
            }
        }
    }
}

