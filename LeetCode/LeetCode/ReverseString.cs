namespace InterviewPrep.LeetCode
{
    public static class ReverseString
    {
        /*
         * Runtime: 200 ms, faster than 99.60% of C# online submissions for Reverse String.
         * Memory Usage: 47.1 MB, less than 52.66% of C# online submissions for Reverse String.
        */
        public static void ReverseStringMethod(char[] s)
        {
            var index1 = 0;
            var index2 = s.Length - 1;

            while (index1 < index2)
            {
                var temp = s[index1];
                s[index1] = s[index2];
                s[index2] = temp;
                index1++;
                index2--;
            }
        }

        /*
            Write a function that reverses a string. The input string is given as an array of characters s.

            You must do this by modifying the input array in-place with O(1) extra memory.

            Example 1:
            Input: s = ["h","e","l","l","o"]
            Output: ["o","l","l","e","h"]

            Example 2:
            Input: s = ["H","a","n","n","a","h"]
            Output: ["h","a","n","n","a","H"]
 
            Constraints:

            1 <= s.length <= 105
            s[i] is a printable ascii character.
         */
    }
}
