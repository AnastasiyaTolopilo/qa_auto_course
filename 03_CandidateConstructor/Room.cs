namespace _03_CandidateConstructor
{
    internal class Room
    {
        public string Type { get; set; }

        public Room(string type)
        {
            Type = type;
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
