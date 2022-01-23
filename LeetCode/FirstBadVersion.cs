using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return version >= 1702766719;
        }
    }
    public class FidnBadVersion : VersionControl
    {
        public int FirstBadVersion(int n)
        {

            long min = 1;
            long max = n;
            while (min <= max)
            {
                long mid = (min + max) / 2;

                if (IsBadVersion((int)mid) && !IsBadVersion((int)mid -1))
                {
                    return (int) mid;
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
    }
}
