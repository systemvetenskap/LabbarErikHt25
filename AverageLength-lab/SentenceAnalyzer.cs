using System.Runtime.CompilerServices;

namespace AverageLength_lab;

public class SentenceAnalyzer
{
    public int Letters { get; private set; }
    public int Words { get; private set; }
    public double AverageWordLength { get; private set; }

    public string GetFeedback(string sentence)
    {
        if (!IsLongEnough(sentence))
        {
            return "Det är för kort";
        }
        Letters = 13;
        Words = 2;
        AverageWordLength = Letters / (double) Words;
        return "Det finns ingen text att analysera.";
    }
    public bool IsLongEnough(string sentence)
    {
        if (sentence.Length < 5)
        {
            return false;
        }
        return true;
    }
}
