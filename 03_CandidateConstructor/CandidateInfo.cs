namespace _03_CandidateConstructor
{
    internal class CandidateInfo
    {
        public Person person { get; set; }
        public SubjectScore[] subjectScores { get; set; }

        public CandidateInfo(Person personValue, SubjectScore[] subjectScoresValue)
        {
            person = personValue;
            subjectScores = subjectScoresValue;
        }
    }
}

