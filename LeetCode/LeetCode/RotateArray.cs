namespace InterviewPrep.LeetCode
{
    public static class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            var arr = new int[nums.Length - k];
            for (int i = 0; i < nums.Length - k; i++)
            {
                arr[i] = nums[i];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = nums[i + nums.Length - k];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                nums[i + k] = arr[i];
            }
        }

        public static void Rotate2(int[] nums, int k)
        {

            if (nums == null || nums.Length < 2)
            {
                return;
            }

            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - k - 1);
            Reverse(nums, nums.Length - k, nums.Length - 1);
            Reverse(nums, 0, nums.Length - 1);

        }

        private static void Reverse(int[] nums, int i, int j)
        {
            int tmp = 0;
            while (i < j)
            {
                tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++;
                j--;
            }
        }
    }
}
