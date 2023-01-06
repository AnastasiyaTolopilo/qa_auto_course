using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class SubjectScore
    {
        public int Score;
        public string SubjectName;

        public SubjectScore(int score, string subjectName)
        {
            Score = score;
            SubjectName = subjectName;
        }
    }
}

