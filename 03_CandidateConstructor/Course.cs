namespace _03_CandidateConstructor
{
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Course(string title, string description)
        {
            Title = title;
            Description = description;
        }


        public override bool Equals(object obj)
        {
            if (obj is Course)
            {
                Course course = obj as Course;
                return course.Title.Equals(Title) && course.Description.Equals(Description);
            }
            else
            {
                return false;
            }
        }
    }
}
