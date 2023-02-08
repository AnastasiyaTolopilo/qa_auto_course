namespace _03_CandidateConstructor
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, Address address)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(surname,nameof(surname));
            Name = name;
            Surname = surname;
            Address = address;
        }


        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return person.Name.Equals(Name) && 
                    person.Surname.Equals(Surname) && 
                    person.Address.Equals(Address);
            }
            else
            {
                return false;
            }
        }

        public int FullNameLenght()
        {
            return Name.Length + Surname.Length;
        }
    }
}
