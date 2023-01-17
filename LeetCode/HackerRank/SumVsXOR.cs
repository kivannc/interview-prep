namespace InterviewPrep.HackerRank;

internal static partial class Questions
{
    public static long sumXor(long n)
    {
        long count = 0;
        for (long i = 0; i <= n; i++)
        {
            if ((i + n) == (i ^ n))
            {
                count++;
            }
        }
        return count;
    }

    //bitwise O(logN)
    public static long SumXor2(long n)
    {
        var count = 0;
        var number = Convert.ToString(n, 2);
        foreach (var bitValue in number)
        {
            if (bitValue == '0')
            {
                count++;
            }
        }
        return (long)Math.Pow(2, count);
    }
}


