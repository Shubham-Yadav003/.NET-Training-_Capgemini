using System;

public class CricketMatch
{
    public int[] playerScores;
    public int currentIndex;

    public CricketMatch()
    {
        playerScores = new int[5];
        currentIndex = 0;
    }

    public void AddPlayerScore(int score)
    {
        if (score < 0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }

        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores.");
        }

        playerScores[currentIndex] = score;
        currentIndex++;
    }

    public int CalculateTotalScore()
    {
        int total = 0;
        for (int i = 0; i < currentIndex; i++)
        {
            total += playerScores[i];
        }
        return total;
    }
}

public class Program
{
    static void Main()
    {
        CricketMatch match = new CricketMatch();

        try
        {
            Console.WriteLine("Enter player scores (space-separated):");
            string input = Console.ReadLine();
            string[] scoreStrings = input.Split(' ');

            foreach (string scoreStr in scoreStrings)
            {
                int score = int.Parse(scoreStr);
                match.AddPlayerScore(score);
            }

            int totalScore = match.CalculateTotalScore();
            Console.WriteLine($"Total score of the cricket team: {totalScore}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}