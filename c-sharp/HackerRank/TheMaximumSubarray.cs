namespace InterviewPrep.HackerRank;

internal partial class Questions
{
    // [-1, 2, 3, -4, 5, 10]
    public static List<int> MaxSubarray(List<int> arr)
    {
        var result = new int[2];
        var maxSum = arr[0];
        var currentSum = arr[0];
        var subsequenceSum = arr[0] > 0 ? arr[0] : 0;
        var allNegative = true;
        var max = arr[0];
        for (var i = 1; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                allNegative = false;
            }
            max = Math.Max(max, arr[i]);

            subsequenceSum += arr[i] > 0 ? arr[i] : 0;
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        result[0] = maxSum;
        result[1] = allNegative ? max : subsequenceSum;

        return result.ToList();
    }
}
