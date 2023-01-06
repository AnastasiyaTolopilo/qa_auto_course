namespace _03_CandidateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectScore scoreMathCandidate1 = new SubjectScore(90, "Math");
            SubjectScore scorePhysicsCandidate1 = new SubjectScore(70, "Physics");
            SubjectScore scoreLithCandidate1 = new SubjectScore(95, "Litherature");
            SubjectScore scoreLanguageCandidate1 = new SubjectScore(98, "Language");

            SubjectScore[] subjectScoresCandidate1 = { scoreMathCandidate1, scorePhysicsCandidate1, scoreLithCandidate1, scoreLanguageCandidate1 };

            Address addressCandidate1 = new Address("Wroclaw", "Czarnuszkowa", "12b", 3);
            Person personCandidate1 = new Person("Nastya", "Talapila", addressCandidate1);

            CandidateInfo candidate1 = new CandidateInfo(personCandidate1, subjectScoresCandidate1);





            SubjectScore scoreMathCandidate2 = new SubjectScore(50, "Math");
            SubjectScore scorePhysicsCandidate2 = new SubjectScore(90, "Physics");
            SubjectScore scoreLithCandidate2 = new SubjectScore(60, "Litherature");
            SubjectScore scoreLanguageCandidate2 = new SubjectScore(55, "Language");

            SubjectScore[] subjectScoresCandidate2 = { scoreMathCandidate2, scorePhysicsCandidate2, scoreLithCandidate2, scoreLanguageCandidate2 };

            Address addressCandidate2 = new Address("Wroclaw", "Czarnuszkowa", "20", 5);
            Person personCandidate2 = new Person("Pavel", "Talapila", addressCandidate2);

            CandidateInfo candidate2 = new CandidateInfo(personCandidate2, subjectScoresCandidate2);





            SubjectScore scoreMathCandidate3 = new SubjectScore(20, "Math");
            SubjectScore scorePhysicsCandidate3 = new SubjectScore(30, "Physics");
            SubjectScore scoreLithCandidate3 = new SubjectScore(90, "Litherature");
            SubjectScore scoreLanguageCandidate3 = new SubjectScore(90, "Language");

            SubjectScore[] subjectScoresCandidate3 = { scoreMathCandidate3, scorePhysicsCandidate3, scoreLithCandidate3, scoreLanguageCandidate3 };

            Address addressCandidate3 = new Address("Minsk", "Dzerzinskogo", "16", 55);
            Person personCandidate3 = new Person("Ivanova", "Katy", addressCandidate3);

            CandidateInfo candidate3 = new CandidateInfo(personCandidate3, subjectScoresCandidate3);





            SubjectScore scoreMathCandidate4 = new SubjectScore(80, "Math");
            SubjectScore scorePhysicsCandidate4 = new SubjectScore(20, "Physics");
            SubjectScore scoreLithCandidate4 = new SubjectScore(70, "Litherature");
            SubjectScore scoreLanguageCandidate4 = new SubjectScore(95, "Language");

            SubjectScore[] subjectScoresCandidate4 = { scoreMathCandidate4, scorePhysicsCandidate4, scoreLithCandidate4, scoreLanguageCandidate4 };

            Address addressCandidate4 = new Address("Minsk", "Prityckogo", "78a", 13);
            Person personCandidate4 = new Person("Petrov", "Petr", addressCandidate4);

            CandidateInfo candidate4 = new CandidateInfo(personCandidate4, subjectScoresCandidate4);





            SubjectScore scoreMathCandidate5 = new SubjectScore(95, "Math");
            SubjectScore scorePhysicsCandidate5 = new SubjectScore(85, "Physics");
            SubjectScore scoreLithCandidate5 = new SubjectScore(70, "Litherature");
            SubjectScore scoreLanguageCandidate5 = new SubjectScore(95, "Language");

            SubjectScore[] subjectScoresCandidate5 = { scoreMathCandidate5, scorePhysicsCandidate5, scoreLithCandidate5, scoreLanguageCandidate5 };

            Address addressCandidate5 = new Address("Vitebsk", "Pobedy", "130", 21);
            Person personCandidate5 = new Person("Sidorova", "Inna", addressCandidate5);

            CandidateInfo candidate5 = new CandidateInfo(personCandidate5, subjectScoresCandidate5);




            CandidateInfo[] Candedates = { candidate1, candidate2, candidate3, candidate4, candidate5 };
            int max = 0;

            foreach (CandidateInfo candidate in Candedates)
            {
                foreach (SubjectScore subjectScore in candidate.subjectScores)
                {
                    if (subjectScore.SubjectName == "Math")
                    {
                        if (max < subjectScore.Score)
                        {
                            max = subjectScore.Score;
                        }
                    }
                }

                Console.WriteLine("Candidate street: " + candidate.person.address.Street);
                Console.WriteLine();
            }

            Console.WriteLine("Max Math score: " + max);
        }
    }
}