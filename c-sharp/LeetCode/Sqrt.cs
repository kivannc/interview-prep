namespace InterviewPrep.LeetCode;

//Squareroot with binary search
public class Sqrt
{
    public static int MySqrt(int x)
    {
        if (x == 0 || x == 1)
            return x;

        long start = 1, end = x, ans = 0;
        while (start <= end)
        {
            long mid = start + (end - start) / 2;

            // If x is a perfect square
            if (mid * mid == x)
                return (int)mid;

            // Since we need floor, we update answer when mid*mid is
            // smaller than x, and move closer to sqrt(x)
            if (mid * mid < x)
            {
                start = mid + 1;
                ans = mid;
            }
            else // If mid*mid is greater than x
                end = mid - 1;
        }
        return (int)ans;
    }
}
