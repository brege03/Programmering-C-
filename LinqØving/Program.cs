using System;
using System.Collections.Generic;
using System.Linq;
class LinqØving
{
    static void Main()
    {
        List<int> scores = new List<int> {97, 92, 112, 89, 50, 3, 81, 60};
       
        Console.WriteLine("Original scores:");
        foreach(int score in scores)
        {
            Console.WriteLine($"The score is: {score}");
        }
        int originalScoreCount = scores.Count;
        Console.WriteLine($"The number of scores are: {originalScoreCount}");
       
        /*IEnumerable<string> scoreQuery =
            from score in scores
            where score > 80
            orderby score descending
            select $"The score is {score}";
            */
           
        var scoreQuery = scores.Where(s => s > 80). OrderByDescending(s => s);
        //Kan brukes i stedet for den over
       
        Console.WriteLine("\nScores above 80:");
        foreach(int i in scoreQuery)
        {
            Console.WriteLine(i);
        }
        int scoreCount = scoreQuery.Count();
        Console.WriteLine($"The numbers of scores are: {scoreCount}");
    }
}