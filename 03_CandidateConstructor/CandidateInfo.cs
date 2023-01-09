namespace _03_CandidateConstructor
{
    internal class CandidateInfo
    {
        public Person Person { get; set; }
        public SubjectScore[] SubjectScores { get; set; }

        public CandidateInfo(Person personValue, SubjectScore[] subjectScoresValue)
        {
            Person = personValue;
            SubjectScores = subjectScoresValue;
        }
    }
}

