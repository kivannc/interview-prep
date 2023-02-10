namespace InterviewPrep.LeetCode;

public class SearchInRotatedArray
{
    public static int Search(int[] nums, int target)
    {

        if (nums.Length == 1) return nums[0] == target ? 0 : -1;
        var rotateIndex = 0;
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                rotateIndex = mid + 1;
                break;
            }
            else if (nums[mid] > nums[nums.Length - 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        left = 0;
        right = rotateIndex - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        left = rotateIndex;
        right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
