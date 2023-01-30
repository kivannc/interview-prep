using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.HackerRank
{
    internal partial class Questions
    {
        public static List<int> Waiter(List<int> number, int q)
        {
            var primes = GetNthPrimeNumber(q);
            Stack<int> plates = new Stack<int>(number);
            Stack<int> plateHolder = new Stack<int>();
            Stack<int> answers = new Stack<int>();

            for (int i = 0; i < primes.Count; i++)
            {
                while (plates.Any())
                {
                    var plate = plates.Pop();
                    if (plate % primes[i] == 0)
                    {
                        answers.Push(plate);
                    }
                    else
                    {
                        plateHolder.Push(plate);
                    }
                }

                while (plateHolder.Any())
                {
                    plates.Push(plateHolder.Pop());
                }
            }

            if (plates.Count > 0)
            {
                while (plates.Any())
                {
                    answers.Push(plates.Pop());
                }
            }

            return plates.ToList();
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
}
