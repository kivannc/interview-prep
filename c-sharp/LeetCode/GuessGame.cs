using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrep.LeetCode;

public class GuessGame
{
    // The guess API is defined in the parent class GuessGame. Provided by LeetCode
    public static int guess(int num)
    {
        return 0;
    }

    public static int GuessNumber(int n)
    {

        if (n == 1) return 1;
        int left = 0;
        int right = n;
        while (true)
        {

            var mid = left + (right - left) / 2;
            var result = guess(mid);
            if (result == 0)
            {
                return mid;
            }
            else if (result == 1)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
    }
}
