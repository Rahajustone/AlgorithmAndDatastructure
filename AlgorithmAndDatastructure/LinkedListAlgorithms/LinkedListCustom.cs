using System;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms
{
    public class LinkedListCustomTest
    {
        private Node _head;

        public void PrintNode()
        {
            while (_head != null)
            {
                Console.WriteLine(_head.Data);
                _head = _head.next;
            }
        }

        public int CountNode()
        {
            int nodeCount = 0;
            while (_head != null)
            {
                nodeCount++;
                _head = _head.next;
            }

            return nodeCount;
        }

        public bool Find(int target)
        {
            while (_head != null)
            {
                if (_head.Data == target)
                    return true;
                _head = _head.next;
            }

            return false;
        }

        // Adding to the end
        public void Append(int data)
        {
            if (_head == null)
            {
                _head = new Node(data);
                return;
            }

            Node current = _head;

            while (current.next != null)
                current = current.next;

            current.next = new Node(data);
        }

        // Adding At the  beginning
        public void Prepand(int data)
        {
            Node newHead = new Node(data);

            newHead.next = _head;
            _head = newHead;
        }

        public void RemoveWithValue(int data)
        {
            if (_head == null) return;

            if (_head.Data == data)
            {
                _head = _head.next;
                return;
            }

            Node current = _head;
            while (_head.next != null)
            {
                if (_head.next.Data == data)
                {
                    _head.next = _head.next.next;
                    return;
                }

                current = current.next;
            }
        }

    }
}