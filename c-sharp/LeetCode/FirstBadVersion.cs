namespace InterviewPrep.LeetCode;

public class VersionControl
{
    public static bool IsBadVersion(int version)
    {
        return version >= 1702766719;
    }
}
public class FirstBadVersionQuestion : VersionControl
{
    public static int FirstBadVersion(int n)
    {

        long min = 1;
        long max = n;
        while (min <= max)
        {
            long mid = (min + max) / 2;

            if (IsBadVersion((int)mid) && !IsBadVersion((int)mid - 1))
            {
                return (int)mid;
            }
            if (!IsBadVersion((int)mid))
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return 1;
    }


    public static int FirstBadVersion2(int n)
    {
        var left = 1;
        while (left < n)
        {
            var mid = left + (n - left) / 2;
            if (IsBadVersion(mid))
            {
                n = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}
