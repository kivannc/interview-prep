// See https://aka.ms/new-console-template for more information


using InterviewPrep.HackerRank;

Questions.ClimbingLeaderboard(new List<int> { 100, 100, 50, 40, 40, 20, 10 }, new List<int> { 5, 25, 50, 120 })
    .ForEach(i => Console.Write("{0} ", i));
Console.WriteLine("\n");
Questions.ClimbingLeaderboard(new List<int> { 100, 90, 90, 80, 75, 60 }, new List<int> { 50, 65, 77, 90, 90, 90 })
    .ForEach(i => Console.Write("{0} ", i));
Console.WriteLine("\n");
Questions.ClimbingLeaderboard(new List<int> { 100, 100, 90, 90, 80, 80, 70, 60, 60, 50 }, new List<int> { 45, 50, 75, 80, 102, 105, 120 })
    .ForEach(i => Console.Write("{0} ", i));
Console.WriteLine("\n");
Console.ReadKey();