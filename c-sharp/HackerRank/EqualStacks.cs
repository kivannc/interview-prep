namespace InterviewPrep.HackerRank;

internal partial class Questions
{   //My solution
    public static int EqualStacks(List<int> h1, List<int> h2, List<int> h3)
    {
        var sum1 = h1.Sum();
        var sum2 = h2.Sum();
        var sum3 = h3.Sum();

        while (true)
        {
            //If all the sums are equal, return any of them
            //They will all go zero any definetly return a value

            if (sum1 == sum2 && sum2 == sum3)
            {
                return sum1;
            }

            if (sum1 >= sum2 && sum1 >= sum3)
            {
                sum1 -= h1[0];
                h1.RemoveAt(0);
            }
            else if (sum2 >= sum1 && sum2 >= sum3)
            {
                sum2 -= h2[0];
                h2.RemoveAt(0);
            }
            else if (sum3 >= sum1 && sum3 >= sum2)
            {
                sum3 -= h3[0];
                h3.RemoveAt(0);
            }
        }
    }

    //Added reverse function to the list to make it a stack
    public static int EqualStacksCopilot(List<int> h1, List<int> h2, List<int> h3)
    {
        h1.Reverse();
        h2.Reverse();
        h3.Reverse();
        var stack1 = new Stack<int>(h1);
        var stack2 = new Stack<int>(h2);
        var stack3 = new Stack<int>(h3);

        var sum1 = stack1.Sum();
        var sum2 = stack2.Sum();
        var sum3 = stack3.Sum();

        while (true)
        {
            if (sum1 == sum2 && sum2 == sum3)
            {
                return sum1;
            }

            if (sum1 >= sum2 && sum1 >= sum3)
            {
                sum1 -= stack1.Pop();
            }
            else if (sum2 >= sum1 && sum2 >= sum3)
            {
                sum2 -= stack2.Pop();
            }
            else if (sum3 >= sum1 && sum3 >= sum2)
            {
                sum3 -= stack3.Pop();
            }
        }
    }
}
