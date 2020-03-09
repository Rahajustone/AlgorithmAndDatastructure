using System;
namespace AlgorithmAndDatastructure.StackAndQueues
{
    public class LinkedListedQueue
    {
        public LinkedListedQueue()
        {
        }

        private class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
            }
        }

        private Node _head; // Remove from head

        private Node _tail; // Add to tail

        public Boolean IsEmpty() => _head == null;

        public int Peek() => _head.Data;

        public void Queue(int data)
        {
            var newNode = new Node(data);

            if (_tail != null)
            {
                _tail.Next = newNode;
            }

            _tail = newNode;

            if(_head == null)
            {
                _head = newNode;
            }
        }

        public int Dequeue()
        {
            int data = _head.Data;

            _head = _head.Next;

            if (_head == null)
            {
                _tail = null;
            }

            return data;
        }
    }
}
