namespace InterviewPrep.LeetCode;

public static class SquaresOfASortedArray
{
  public static int[] SortedSquares(int[] nums)
  {
    int n = nums.Length;
    int k;
    for (k = 0; k < n; k++)
    {
      if (nums[k] >= 0)
        break;
    }

    // Now do the same process that we learnt
    // in merge sort to merge to two sorted array
    // here both two halves are sorted and we traverse
    // first half in reverse manner because
    // first half contains negative elements
    int i = k - 1; // Initial index of first half
    int j = k; // Initial index of second half
    int ind = 0; // Initial index of temp array

    int[] temp = new int[n];
    while (i >= 0 && j < n)
    {
      if (nums[i] * nums[i] < nums[j] * nums[j])
      {
        temp[ind] = nums[i] * nums[i];
        i--;
      }
      else
      {
        temp[ind] = nums[j] * nums[j];
        j++;
      }
      ind++;
    }

    while (i >= 0)
    {
      temp[ind++] = nums[i] * nums[i];
      i--;
    }
    while (j < n)
    {
      temp[ind++] = nums[j] * nums[j];
      j++;
    }

    // copy 'temp' array into original array
    for (int x = 0; x < n; x++)
      nums[x] = temp[x];

    return nums;
  }
}