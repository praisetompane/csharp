Console.WriteLine("Basic LINQ");
List<int> testScores = [90, 67, 80, 12, 78, 56, 91, 100];

IEnumerable<int> A_scores =
    from score in testScores
    where score > 80
    orderby score descending
    select score;

foreach (var score in A_scores)
{
    Console.WriteLine(score);
}

Console.WriteLine(string.Join(", ", A_scores));
Console.WriteLine(string.Join(", ", A_scores.ToList()));

Console.WriteLine("End Basic LINQ");