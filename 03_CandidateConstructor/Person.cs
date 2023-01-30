namespace _03_CandidateConstructor
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, Address address)
        {
            Name = name;
            Surname = surname;
            Address = address;
        }


        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person;
                return person.Name.Equals(Name) && 
                    person.Surname.Equals(Surname) && 
                    person.Address.Equals(Address);
            }
            else
            {
                return false;
            }
        }
    }
}
