using System;
namespace PracticeExercise3
{

    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T data = default(T), DoublyLinkedListNode<T> prev = null, DoublyLinkedListNode < T> next = null)
        {
            Data = data;
            Prev = prev;
            Next = next;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class DoublyLinkedList: IList<T>
    {
        public DoublyLinkedList()
        {
        }
    }
}
