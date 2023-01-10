namespace _03_CandidateConstructor
{
    internal class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Course(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
