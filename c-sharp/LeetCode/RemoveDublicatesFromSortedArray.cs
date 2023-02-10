namespace InterviewPrep.LeetCode;

public class RemoveDublicatesFromSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }
        var currentElement = nums[0];
        var k = 1;
        var startIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == currentElement)
            {
                nums[i] = int.MaxValue;
                if (startIndex == 0)
                {
                    startIndex = i;
                }
            }
            else
            {
                currentElement = nums[i];
                k++;
            }
        }

        if (k == nums.Length) return k;

        for (int j = startIndex; j < nums.Length; j++)
        {
            if (nums[j] != int.MaxValue)
            {
                nums[startIndex] = nums[j];
                startIndex++;
                nums[j] = int.MaxValue;
            }
        }

        return k;

    }
}
