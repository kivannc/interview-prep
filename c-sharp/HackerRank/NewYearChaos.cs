namespace InterviewPrep.HackerRank;

internal partial class Questions
{
  public static void MinimumBribes(List<int> q)
  {
    var sumOfChanges = 0;
    for (int i = 0; i < q.Count; i++)
    {
      if (q[i] - (i + 1) > 2)
      {
        Console.WriteLine("Too chaotic");
        return;
      }
      var iteration = 0;
      for (int j = Math.Max(0, q[i] - 2); j < i; j++)
      {
        if (q[j] > q[i])
        {
          sumOfChanges++;
        }
      }
      sumOfChanges += iteration;
    }
    Console.WriteLine(sumOfChanges);
  }
}
