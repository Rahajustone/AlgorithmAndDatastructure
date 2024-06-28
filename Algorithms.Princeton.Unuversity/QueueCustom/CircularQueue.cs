using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Princeton.Unuversity.QueueCustom;

public class Node
{

    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}
public class CircularQueue
{
    private Node head;
    private Node tail;
    public int Count  = 0;

    public CircularQueue()
    {
    }

    public void InsertFront(int value)
    {
        Count++;
        var newNode = new Node(value, head, tail);
        if (head == null)
        {
            head = newNode;
            tail = head;
        } else
        {
            head = newNode;
        }
    }

    public void InsertLast(int value) {
        Count++;
        var newNode = new Node(value, head, tail);
        if (tail == null)
        {
            tail = newNode;
            head = tail;
        }
        else
        {
            tail = newNode;
        }
    }

    public int GetFront()
    {
        return head.Value;
    }

    public void PrintAll()
    {
        var temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Left;
        }
    }

    public void PrintAllFromLast()
    {
        var temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Right;
        }
    }
}
