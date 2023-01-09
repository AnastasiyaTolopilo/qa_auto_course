namespace _03_CandidateConstructor
{
    internal class Building: UniversityProperty
    {
        public Address BuildingAddress { get; set; }
        public Room[] Rooms { get; set; } 

        public Building(Address buildingAddress, Room[] roomsValue)
        {
            BuildingAddress = buildingAddress;
            Rooms = roomsValue;
        }
    }
}
