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
            if (obj is Building building)
            {
                bool temp = true;
                foreach (Room r in building.Rooms)
                {
                    if (!Rooms.Contains(r)) { temp = false; break; }
                }
                if (!temp) { return false; }

                return building.BuildingAddress.Equals(BuildingAddress);
            }
            else
            {
                return false;
            }
        }

        public void AddRoom(Room itemToCheck)
        {
            if (!Rooms.Contains(itemToCheck)) 
            {
                Rooms.Add(itemToCheck);
            }
        }
    }
}
