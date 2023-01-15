namespace _03_CandidateConstructor
{
    internal class Building: UniversityProperty
    {
        public Address BuildingAddress { get; set; }
        public List<Room> Rooms { get; set; } 

        public Building(Address buildingAddress, List<Room> rooms)
        {
            BuildingAddress = buildingAddress;
            Rooms = rooms;
        }



        public override bool Equals(object obj)
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

        public void AddRoom(Room itemToCheck)
        {
            foreach (Room item in Rooms.ToList())
            {
                if (item.Equals(itemToCheck))
                {
                    return;
                }
            }

            Rooms.Add(itemToCheck);
        }
    }
}
