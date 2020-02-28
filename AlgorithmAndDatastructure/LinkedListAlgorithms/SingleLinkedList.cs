using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms
{
    class SingleNode
    {
        public int Data;
        public SingleNode NextNode;

        public SingleNode(int data)
        {
            this.Data = data;
        }
    }
    class SingleLinkedList
    {
        private SingleNode _head;

        public SingleLinkedList()
        {
            
        }
        public SingleLinkedList(SingleNode head)
        {
            this._head = head;
        }

        // Print Node List
        public void PrintLinkedList()
        {
            SingleNode printNode = _head;
            while (printNode != null)
            {
                Console.WriteLine(printNode.Data);
                printNode = printNode.NextNode;
            }
        }
        
        // Get Head NOde
        public SingleNode GetHead()
        {
            return _head;
        }

        // Get Head Node Value
        public int GetHeadValue()
        {
            return _head.Data;
        }

        // This Methods add to the beginning of the node
        public void PreAppend(int data)
        {
           var newNode = new SingleNode(data);
           newNode.NextNode = _head;
           _head = newNode;
        }

        // This Methods add to the enf of element
        public void Append(int data)
        {
            var newNode = new SingleNode(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.NextNode = null;

            SingleNode lastNode = _head;

            while (lastNode.NextNode != null)
                lastNode = lastNode.NextNode;

            lastNode.NextNode = newNode;
        }

        // Insert After Node
        public void InsertAfterNode(SingleNode prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Node is null.");
                return;
            }

            var newNode = new SingleNode(data) {NextNode = prevNode.NextNode};
            prevNode.NextNode = newNode;
        }

        // Delete with key
        public void DeleteKey(int key)
        {
            SingleNode tempNode = _head, prevNode = null;

            if (tempNode != null && tempNode.Data == key)
            {
                _head = tempNode.NextNode;
                return;
            }

            while (tempNode.NextNode != null && tempNode.Data != key)
            {
                prevNode = tempNode;
                tempNode = tempNode.NextNode;
            }

            // Key not found
            if (tempNode == null) return;

            prevNode.NextNode = tempNode.NextNode;
        }


        // Get The first Node
        public SingleNode GetTheFirstNode()
        {
            return _head;
        }


        // Get First Node Data
        public int GetFirstNodeValue()
        {
            if (GetTheFirstNode() != null)
            {
                return GetTheFirstNode().Data;
            }

            return -1;
        }

        // Get The last Node
        public SingleNode GetTheLastNode()
        {
            SingleNode lastNode = _head;

            if (_head == null) return null;

            while (lastNode.NextNode != null)
                lastNode = lastNode.NextNode;

            return lastNode;
        }

        // Get the last node value
        public int GetTheLastNodeValue()
        {
            if (GetTheLastNode() != null)
                return GetTheLastNode().Data;

            return -1;
        }


        // Get Node Count
        public int GetCountNode()
        {
            SingleNode headNode = _head;

            int countNode = 0;

            while (headNode != null)
            {
                countNode++;
                headNode = headNode.NextNode;
            }

            return countNode;
        }

        // Clear Nodes
        public void Clear()
        {
            _head = null;
        }
    }
}
