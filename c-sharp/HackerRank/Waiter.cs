namespace InterviewPrep.HackerRank;

internal partial class Questions
{
    public static List<int> Waiter(List<int> number, int q)
    {
        var primes = GetNthPrimeNumber(q);
        Stack<int> initalStack = new Stack<int>(number);
        Stack<int> pilaA = new Stack<int>();
        Stack<int> pileB = new Stack<int>();
        var answers = new List<int>();

        //First iteration 
        var firstPrime = primes[0];
        while (initalStack.Any())
        {
            var plate = initalStack.Pop();
            if (plate % firstPrime == 0)
            {
                pileB.Push(plate);
            }
            else
            {
                pilaA.Push(plate);
            }
        }

        while (pileB.Any())
        {
            answers.Add(pileB.Pop());
        }

        for (int i = 1; i < primes.Count; i++)
        {
            var prime = primes[i];
            while (pilaA.Any())
            {
                var plate = pilaA.Pop();
                if (plate % prime == 0)
                {
                    pileB.Push(plate);
                }
                else
                {
                    initalStack.Push(plate);
                }
            }

            while (pileB.Any())
            {
                answers.Add(pileB.Pop());
            }

            var stack = new Stack<int>();
            while (initalStack.Any())
            {
                stack.Push(initalStack.Pop());
            }

            while (stack.Any())
            {
                pilaA.Push(stack.Pop());
            }
        }

        while (pilaA.Any())
        {
            answers.Add(pilaA.Pop());
        }
        return answers;
    }
    public static List<int> GetNthPrimeNumber(int primeCount)
    {
        var primes = new List<int>();
        var number = 2;

        while (primeCount > 0)
        {
            var isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(number);
                primeCount--;
            }
            number++;
        }

        return primes;
    }
}
