// See https://aka.ms/new-console-template for more information
using InterviewPrep.HackerRank;


var answers1 = Questions.Waiter(new List<int> { 2, 3, 4, 5, 6, 7 }, 3);
var answers2 = Questions.Waiter(new List<int> { 3, 4, 7, 6, 5 }, 1);
var answers3 = Questions.Waiter(new List<int> { 3, 4, 7, 6, 5 }, 1);

Console.WriteLine(string.Join(' ', answers1));
Console.WriteLine(string.Join(' ', answers2));


Console.ReadKey();