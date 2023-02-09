namespace InterviewPrep.HackerRank;

internal partial class Questions
{
    public static void SimpleTextEditor()
    {
        var stack = new Stack<(string, string)>();
        var numberOfQueries = Convert.ToInt32(Console.ReadLine());

        var index = 1;
        var resultStr = "";
        while (index <= numberOfQueries)
        {
            var inputStr = Console.ReadLine();
            var inputArr = inputStr.Split(' ');

            if (inputArr[0] == "1")
            {
                resultStr += inputArr[1];
                stack.Push((inputArr[0], inputArr[1]));
            }

            if (inputArr[0] == "2")
            {
                var deleteNumber = Convert.ToInt32(inputArr[1]);
                var deleted = resultStr.Substring(resultStr.Length - deleteNumber);
                resultStr = resultStr.Substring(0, resultStr.Length - deleteNumber);
                stack.Push((inputArr[0], deleted));
            }

            if (inputArr[0] == "3")
            {
                var printIndex = Convert.ToInt32(inputArr[1]);
                Console.WriteLine(resultStr[printIndex]);
            }

            if (inputArr[0] == "4")
            {
                var (queryType, queryParam) = stack.Pop();
                if (queryType == "1")
                {
                    resultStr = resultStr.Substring(0, resultStr.Length - queryParam.Length);
                }

                if (queryType == "2")
                {
                    resultStr += queryParam;
                }
            }
        }
    }
}

