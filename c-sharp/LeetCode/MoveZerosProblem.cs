namespace InterviewPrep.LeetCode;

public static class MoveZerosProblem
{
  public static void MoveZeros(int[] nums)
  {
    if (nums.Length == 1 || nums.Length == 0)
    {
      return;
    }
    int first = nums.Length - 2;
    int last = nums.Length - 1;

    while (first >= 0)
    {
      if (nums[last] != 0 && nums[first] == 0)
      {
        Swap(nums, first, last);

        if (last != nums.Length - 1)
        {
          first++;
          last++;
        }
      }
      else
      {
        first--;
        last--;
      }


    }

    void Swap(int[] nums, int first, int last)
    {

      int temp = nums[first];
      nums[first] = nums[last];
      nums[last] = temp;
    }
  }

  public static void MoveZerosV2(int[] nums)
  {
    if (nums.Length == 1 || nums.Length == 0)
    {
      return;
    }
    int first = nums.Length - 2;
    int last = nums.Length - 1;

    while (first >= 0)
    {
      if (nums[last] != 0 && nums[first] == 0)
      {
        MoveToEnd(nums, first);
      }
      first--;
      last--;
    }

    void MoveToEnd(int[] nums, int first)
    {
      while (first < nums.Length - 1)
      {

        var target = first + 1;
        if (nums[first] == 0 && nums[target] == 0)
        {
          break;
        }
        int temp = nums[first];
        nums[first] = nums[target];
        nums[target] = temp;
        first++;
      }
    }
  }

  public static void MoveZerosV3(int[] nums)
  {
    int nonZeroIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] == 0)
        continue;

      nums[nonZeroIndex++] = nums[i];
    }
    for (int i = nonZeroIndex; i < nums.Length; i++)
    {
      nums[i] = 0;
    }
  }
}

/*
 * 
 * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 */ 