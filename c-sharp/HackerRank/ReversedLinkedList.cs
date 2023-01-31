namespace InterviewPrep.HackerRank;

internal partial class Questions
{

  public class SinglyLinkedListNode
  {
    public int Data { get; set; }
    public SinglyLinkedListNode Next { get; set; }

  }
  public static SinglyLinkedListNode Reverse(SinglyLinkedListNode linkedList)
  {

    SinglyLinkedListNode previousNode = null;
    SinglyLinkedListNode currentNode = linkedList;

    while (currentNode != null)
    {
      var nextNode = currentNode.Next;

      currentNode.Next = previousNode;
      currentNode = nextNode;
    }

    linkedList = previousNode;
    return linkedList;
  }

}