namespace _03_CandidateConstructor
{
    public class Room
    {
        public string Type { get; set; }
        public int RoomNumber { get; set; }

        public Room(string type, int roomNumber)
        {
            Type = type;
            RoomNumber = roomNumber;
        }


        public override bool Equals(object obj)
        {
            if (obj is Room)
            {
                Room room = obj as Room;
                return room.Type.Equals(Type);
            }
            else
            {
                return false;
            }
        }
    }
}
