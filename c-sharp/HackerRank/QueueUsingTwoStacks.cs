namespace InterviewPrep.HackerRank;

internal partial class Questions
{
  public static void RunQueries()
  {
    var queue = new Queue<int>();
    var numberOfQueries = Convert.ToInt32(Console.ReadLine());
    while (numberOfQueries > 0)
    {
      var query = Console.ReadLine()!.Split(" ").Select(u =>
          Convert.ToInt32(u)).ToArray();
      var command = query[0];
      switch (command)
      {
        case 1:
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

public class Queue<T>
{
  private readonly Stack<T> _stack1;
  private readonly Stack<T> _stack2;
  public Queue()
  {
    _stack1 = new Stack<T>();
    _stack2 = new Stack<T>();
  }

  public void Enqueue(T item)
  {
    foreach (var x1 in _stack1)
    {
      _stack2.Push(x1);
    }
    _stack2.Push(item);

    foreach (var x1 in _stack2)
    {
      _stack1.Push(x1);
    }
  }

  public void Dequeue()
  {
    _stack1.Pop();
  }

  public void PrintFirst()
  {
    Console.WriteLine(_stack2.First());

  }
}