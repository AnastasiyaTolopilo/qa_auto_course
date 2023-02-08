namespace _03_CandidateConstructor
{
    public class SubjectScore
    {
        const int MAX_SCORE = 100;
        private int _score;
        public int Score 
        {
            get 
            { 
                return _score; 
            } 
            set
            { 
                if (value >= 0 && value <= MAX_SCORE) {
                    _score = value; 
                } 
            } 
        }
        public string SubjectName { get; set; }

        public SubjectScore(int score, string subjectName)
        {
            Score = score;
            SubjectName = subjectName;
        }
    }
}

