using System.Numerics;

namespace _03_CandidateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addressEmployee1 = new Address("Minsk", "Prityckogo", "146", 4);
            Address addressEmployee2 = new Address("Mogilew", "Kalinowskogo", "167", 45);
            Address addressEmployee3 = new Address("Vitebsk", "Mira", "17", 1);
            Address addressEmployee4 = new Address("Grodno", "Swobody", "78a", 7);

            Person personEmployee1 = new Person("Natalya", "Kachan", addressEmployee1);
            Person personEmployee2 = new Person("Peter", "Byko", addressEmployee2);
            Person personEmployee3 = new Person("Oleg", "Bylawski", addressEmployee3);
            Person personEmployee4 = new Person("Elizaweta", "Sinica", addressEmployee4);

            Course courseMath = new Course("Mathematics", "Basics of algebra and geometry");
            Course coursePhysics = new Course("Physics", "Study of the properties and phenomena of inanimate nature");

            UniversityEmployee employee = new UniversityEmployee(personEmployee1, "86298");
            Teacher teacher = new Teacher(personEmployee2, "72937", courseMath);
            DegreeTeacher degree = new DegreeTeacher(personEmployee3, "82637", coursePhysics, "Candidate of Sciences", "Professor");
            SupportStaff staff = new SupportStaff(personEmployee4, "13948", "Cleaner");
            UniversityEmployee[] employees = { employee, teacher, degree, staff };

            foreach (UniversityEmployee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.GetOfficialDuties());
            }
        }
    }
}

