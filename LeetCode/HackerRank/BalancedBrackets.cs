namespace InterviewPrep.HackerRank;

internal partial class Questions
{
    public static string IsBalanced(string s)
    {
        if (s.Length % 2 != 0) return "NO";

        char[] openings = { '{', '[', '(' };
        char[] closing = { '}', ']', ')' };
        Stack<char> bracketQueue = new();

        foreach (var c in s)
        {
            if (!bracketQueue.Any())
            {
                return "NO";
            }

            if (openings.Contains(c))
            {
                bracketQueue.Push(c);
                continue;
            }

            var lastBracket = bracketQueue.Pop();
            if (Array.IndexOf(openings, lastBracket) != Array.IndexOf(closing, c))
            {
                return "NO";
            }
        }
        
        return bracketQueue.Count == 0 ? "YES" : "NO";



    }
}