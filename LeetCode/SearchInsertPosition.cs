using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (target > nums[nums.Length - 1]) return nums.Length;
            if (target < nums[0]) return 1;

            long min = 0;
            long max = nums.Length-1;
            var direction = 0; 
            while (min <= max)
            {
                long mid = (min + max) / 2;

                if (nums[mid] == target || (nums[mid] < target && direction == -1 ) || (nums[mid] > target && direction == 1))
                {
                    return (int)mid+1;
                }
                if (nums[mid]< target)
                {
                    direction= 1;
                    min = mid + 1;
                }
                else
                {
                    direction = -1;
                    max = mid - 1;
                }
            }

            return 1;
        }
    }
}
