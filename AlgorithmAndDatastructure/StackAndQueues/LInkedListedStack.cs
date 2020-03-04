using System;
namespace AlgorithmAndDatastructure.StackAndQueues
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    public class LinkedListedStack
    {
        public Node _head { get; set; }

        public LinkedListedStack()
        {
        }

        public void Push(int data)
        {
            var newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.Next = _head;
            _head = newNode;
        }

        public int Pop()
        {
            if (_head == null) throw new System.ArgumentNullException();

            var result = _head.Data;

            _head = _head.Next;

            return result;
        }

        public void PrintData()
        {
            Node newNode = _head;

            while(newNode != null)
            {
                Console.WriteLine(newNode.Data);
                newNode = newNode.Next;
            }
        }
    }
}
