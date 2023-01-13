namespace _03_CandidateConstructor
{
    internal class Helper
    {
        public static bool AddItem<T>(T[] items, T itemToCheck) 
        {
            foreach (T item in items)
            {
                if (item.Equals(itemToCheck))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
