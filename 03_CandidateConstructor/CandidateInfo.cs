using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class CandidateInfo
    {
        public Person person;
        public SubjectScore[] subjectScores;

        public CandidateInfo(Person personValue, SubjectScore[] subjectScoresValue)
        {
            person = personValue;
            subjectScores = subjectScoresValue;
        }
    }
}

