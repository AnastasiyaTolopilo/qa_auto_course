namespace _03_CandidateConstructor
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, Address addressValue)
        {
            Name = name;
            Surname = surname;
            Address = addressValue;
        }
    }
}

