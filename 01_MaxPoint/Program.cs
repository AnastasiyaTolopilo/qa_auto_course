static float GetAverageScores(int[] scores)
{
    float average = 0;
    for (int i = 0; i < scores.Length; i = i + 1)
    {
        average = average + scores[i];
    }
    average = average / scores.Length;

    return average;
}

static Dictionary<string, int> GetMinMax(int[] scores)
{
    Dictionary<string, int> minMax = new Dictionary<string, int>();
    minMax["min"] = scores[0];
    minMax["max"] = scores[0];

    for (int i = 0; i < 10; i = i + 1)
    {
        if (minMax["min"] < scores[i])
        {
            minMax["min"] = scores[i];
        }

        if (minMax["max"] > scores[i])
        {
            minMax["max"] = scores[i];
        }
    }

    return minMax;
}

int[] scores = { 2, 4, 2, 8, 8, 9, 4, 5, 1, 999 };
int[] scores1 = { 2, 4, 2222, 8, 8, 9, 4, 5, 10, 9 };
int[] scores2 = { 2, 4, 2, 8, 8, 9, 4, 5555, 1, 9 };
int[] scores3 = { 2, 44444, 2, 8, 8, 9, 4, 5, 1, 9 };
int[] scores4 = { 2, 4, 2, 8, 8, 9, 4, 5, 1111, 9 };

float avarege = GetAverageScores(scores);
float avarege1 = GetAverageScores(scores1);
float avarege2 = GetAverageScores(scores2);
float avarege3 = GetAverageScores(scores3);
float avarege4 = GetAverageScores(scores4);

Console.WriteLine("Average values: ");
Console.WriteLine(avarege);
Console.WriteLine(avarege1);
Console.WriteLine(avarege2);
Console.WriteLine(avarege3);
Console.WriteLine(avarege4);
Console.WriteLine();

Dictionary<string, int> minMax = GetMinMax(scores);
Dictionary<string, int> minMax1 = GetMinMax(scores1);
Dictionary<string, int> minMax2 = GetMinMax(scores2);
Dictionary<string, int> minMax3 = GetMinMax(scores3);
Dictionary<string, int> minMax4 = GetMinMax(scores4);

Console.WriteLine("Min: " + minMax["min"]);
Console.WriteLine("Max: " + minMax["max"]);
Console.WriteLine();

Console.WriteLine("Min1: " + minMax1["min"]);
Console.WriteLine("Max1: " + minMax1["max"]);
Console.WriteLine();

Console.WriteLine("Min2: " + minMax2["min"]);
Console.WriteLine("Max2: " + minMax2["max"]);
Console.WriteLine();

Console.WriteLine("Min3: " + minMax3["min"]);
Console.WriteLine("Max3: " + minMax3["max"]);
Console.WriteLine();

Console.WriteLine("Min4: " + minMax4["min"]);
Console.WriteLine("Max4: " + minMax4["max"]);
Console.WriteLine();
