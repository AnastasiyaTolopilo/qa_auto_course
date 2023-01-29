namespace _03_CandidateConstructor
{
    public class CandidateInfo
    {
        public Person Person { get; set; }
        public SubjectScore[] SubjectScores { get; set; }

        public CandidateInfo(Person person, SubjectScore[] subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }
    }
}
