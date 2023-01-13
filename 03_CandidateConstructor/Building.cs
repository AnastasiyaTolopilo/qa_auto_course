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



        public override bool Equels(object obj)
        {
            if (obj is Building)
            {
                Building building = obj as Building;
                return building.BuildingAddress.Equals(BuildingAddress) &&
                    building.Rooms.Equals(Rooms);
            }
            else
            {
                return false;
            }
        }
    }
}
