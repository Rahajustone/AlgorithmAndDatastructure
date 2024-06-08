using System;
namespace Algorithms.Princeton.Unuversity.Stack;

public class LinkedStack<T>: IStack<T>
{
    private Node? head = null;
    public int Count = 0;

    private class Node
    {
        public Node Next { get; set; }
        public T data { get; set; }
        public Node(T item)
        {
            data = item;
        }
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public T Pop()
    {
        T item = head.data;
        head = head.Next;
        Count--;

        return item;
    }

    public void Push(T item)
    {
        Node previousHead = head;
        head = new Node(item);
        head.Next = previousHead;
        Count++;
    }
}
