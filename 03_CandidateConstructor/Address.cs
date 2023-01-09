namespace _03_CandidateConstructor
{
    internal class Address
    {
        private int _house;
        private int _apartment;
        public string City { get; set; }
        public string Street { get; set; }
        public int House 
        { 
            get 
            { 
                return _house; 
            }
            set
            { 
                if (value > 0) { 
                    _house = value; 
                } 
            } 
        } 
        public int Apartment 
        { 
            get 
            {
                return _apartment; 
            } 
            set
            { 
                if (value > 0) {
                    _apartment = value;
                } 
            } 
        }
        public Address(string city, string street, int house, int apartment)
        {
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}
