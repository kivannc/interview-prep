// See https://aka.ms/new-console-template for more information


using InterviewPrep.HackerRank;

var primes = Questions.GetNthPrimeNumber(1200);
Console.WriteLine(primes.Last());

var answers = Questions.Waiter(new List<int> { 2, 3, 4, 5, 6, 7 }, 3);
Console.ReadKey();