using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class Address
    {
        public string City;
        public string Street;
        public string House;
        public int Apartment;

        public Address(string city, string street, string house, int apartment)
        {
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}
