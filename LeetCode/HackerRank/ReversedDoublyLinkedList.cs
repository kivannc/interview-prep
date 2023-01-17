namespace InterviewPrep.HackerRank;

internal partial class Questions
{

    public class DoublyLinkedListNode
    {
        public int Data { get; set; }
        public DoublyLinkedListNode? Next { get; set; }
        public DoublyLinkedListNode? Prev { get; set; }

    }
    public static DoublyLinkedListNode? Reverse(DoublyLinkedListNode? linkedList)
    {

        DoublyLinkedListNode? previousNode = null;
        DoublyLinkedListNode? currentNode = linkedList;

        while (currentNode != null)
        {
            previousNode = currentNode.Prev;
            currentNode.Prev = currentNode.Next;
            currentNode.Next = previousNode;
            currentNode = currentNode.Prev;
        }

        linkedList = previousNode;
        return linkedList;
    }

}