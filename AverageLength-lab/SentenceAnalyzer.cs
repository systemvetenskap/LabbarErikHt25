using System.Runtime.CompilerServices;

namespace AverageLength_lab;

public class SentenceAnalyzer
{
    public int Letters { get; private set; }
   // public readonly int Letters;
    public int Words { get; private set; }
    public double AverageWordLength => Letters / (double)Words;

    public bool IsAboveLimit => AverageWordLength > _lowerLimit;

    private double _upperLimit = 4.4; 
    private double _lowerLimit = 3.5;

    private void CountWordAndLetters(string sentence)
    {
        
        Words = 1;
        foreach (char letter in sentence)
        {
            if (char.IsWhiteSpace(letter))
            {
                Words++;
            }
            else
            {
                Letters++;
            }
        }
    }


    public string GetFeedback(string sentence)
    {
        CountWordAndLetters(sentence);
       // AverageWordLength = Letters / (double) Words;
        return "Det finns ingen text att analysera.";
    }
    private bool IsLongEnough(string sentence)
    {
        if (sentence.Length < 5)
        {
            return false;
        }
        return true;
    }
}
