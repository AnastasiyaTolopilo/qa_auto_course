namespace _03_CandidateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SUBJECT = "Math";

            SubjectScore scoreMathCandidate1 = new (90, "Math");
            SubjectScore scorePhysicsCandidate1 = new (70, "Physics");
            SubjectScore scoreLithCandidate1 = new (95, "Litherature");
            SubjectScore scoreLanguageCandidate1 = new (98, "Language");

            SubjectScore[] subjectScoresCandidate1 = { 
                scoreMathCandidate1, 
                scorePhysicsCandidate1, 
                scoreLithCandidate1, 
                scoreLanguageCandidate1 
            };

            Address addressCandidate1 = new ("Wroclaw", "Czarnuszkowa", 12, 3);
            Person personCandidate1 = new ("Nastya", "Talapila", addressCandidate1);

            CandidateInfo candidate1 = new (
                personCandidate1, 
                subjectScoresCandidate1
            );





            SubjectScore scoreMathCandidate2 = new (50, "Math");
            SubjectScore scorePhysicsCandidate2 = new (90, "Physics");
            SubjectScore scoreLithCandidate2 = new (60, "Litherature");
            SubjectScore scoreLanguageCandidate2 = new (55, "Language");

            SubjectScore[] subjectScoresCandidate2 = { 
                scoreMathCandidate2, 
                scorePhysicsCandidate2, 
                scoreLithCandidate2, 
                scoreLanguageCandidate2 
            };

            Address addressCandidate2 = new ("Wroclaw", "Czarnuszkowa", 20, 5);
            Person personCandidate2 = new ("Pavel", "Talapila", addressCandidate2);

            CandidateInfo candidate2 = new (
                personCandidate2, 
                subjectScoresCandidate2
            );





            SubjectScore scoreMathCandidate3 = new (20, "Math");
            SubjectScore scorePhysicsCandidate3 = new (30, "Physics");
            SubjectScore scoreLithCandidate3 = new (90, "Litherature");
            SubjectScore scoreLanguageCandidate3 = new (90, "Language");

            SubjectScore[] subjectScoresCandidate3 = { 
                scoreMathCandidate3, 
                scorePhysicsCandidate3, 
                scoreLithCandidate3, 
                scoreLanguageCandidate3 
            };

            Address addressCandidate3 = new ("Minsk", "Dzerzinskogo", 16, 55);
            Person personCandidate3 = new ("Ivanova", "Katy", addressCandidate3);

            CandidateInfo candidate3 = new (
                personCandidate3, 
                subjectScoresCandidate3
            );





            SubjectScore scoreMathCandidate4 = new (80, "Math");
            SubjectScore scorePhysicsCandidate4 = new (20, "Physics");
            SubjectScore scoreLithCandidate4 = new (70, "Litherature");
            SubjectScore scoreLanguageCandidate4 = new (95, "Language");

            SubjectScore[] subjectScoresCandidate4 = { 
                scoreMathCandidate4, 
                scorePhysicsCandidate4, 
                scoreLithCandidate4, 
                scoreLanguageCandidate4 
            };

            Address addressCandidate4 = new ("Minsk", "Prityckogo", 78, 13);
            Person personCandidate4 = new ("Petrov", "Petr", addressCandidate4);

            CandidateInfo candidate4 = new (
                personCandidate4, 
                subjectScoresCandidate4
            );





            SubjectScore scoreMathCandidate5 = new (95, "Math");
            SubjectScore scorePhysicsCandidate5 = new (85, "Physics");
            SubjectScore scoreLithCandidate5 = new (70, "Litherature");
            SubjectScore scoreLanguageCandidate5 = new (95, "Language");

            SubjectScore[] subjectScoresCandidate5 = { 
                scoreMathCandidate5, 
                scorePhysicsCandidate5, 
                scoreLithCandidate5, 
                scoreLanguageCandidate5 
            };

            Address addressCandidate5 = new ("Vitebsk", "Pobedy", 130, 21);
            Person personCandidate5 = new ("Sidorova", "Inna", addressCandidate5);

            CandidateInfo candidate5 = new (
                personCandidate5, 
                subjectScoresCandidate5
            );




            CandidateInfo[] Candedates = { 
                candidate1, 
                candidate2, 
                candidate3, 
                candidate4, 
                candidate5 
            };
            int max = 0;

            foreach (CandidateInfo candidate in Candedates)
            {
                foreach (SubjectScore subjectScore in candidate.subjectScores)
                {
                    if (subjectScore.SubjectName == SUBJECT)
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

            Console.WriteLine($"Max {SUBJECT} score: " + max);
        }
    }
}
