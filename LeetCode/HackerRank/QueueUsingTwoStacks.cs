namespace InterviewPrep.HackerRank
{
    internal partial class Questions
    {
        public static void RunQueries()
        {
            var queue = new MyQueue<int>();
            var numberOfQueries = Convert.ToInt32(Console.ReadLine());
            while (numberOfQueries > 0)
            {
                var query = Console.ReadLine()!.Split(" ").Select(u=> 
                    Convert.ToInt32(u)).ToArray();
                var command = query[0];
                switch (command)
                {
                    case 1 :
                        queue.Enqueue(query[1]);
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        queue.PrintFirst();
                        break;
                }

                numberOfQueries--;
            }
        }
    }

    public class MyQueue<T>
    {

        private readonly Stack<T> _stack1 = new Stack<T>();
        private readonly Stack<T> _stack2 = new Stack<T>();


        //implement Enqueue with two stacks 
        public void Enqueue(T item)
        {
            _stack1.Push(item);
        }

        public void Dequeue()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }

            _stack2.Pop();
            
            
        }

        public void PrintFirst()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }

            Console.WriteLine(_stack2.Peek());
        }
    }
}
