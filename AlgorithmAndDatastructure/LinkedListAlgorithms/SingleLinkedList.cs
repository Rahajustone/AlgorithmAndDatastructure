using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms
{
    public class SingleNode
    {
        public int Data;
        public SingleNode NextNode;

        public SingleNode(int data)
        {
            this.Data = data;
        }
    }

    public class SingleNodeLoop : SingleNode
    {
        public int Flag { get; set; } = 0;
        public SingleNodeLoop(int data):base(data)
        {
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


        // Loop detection
        // First Methods to put in hashset and check if it is in HashSet then false else return true
        // We can use HashSet to check if we have loop detection
        /**
            1->2->3
                <-4  
         **/

        public static bool DetectLoop(Node head)
        {
            HashSet<Node> tempNode = new HashSet<Node>();

            while(head != null)
            {
                if (tempNode.Contains(head))
                    return true;

                tempNode.Add(head);
                head = head.next;
            }

            return false;
        }


        // Loop detection with change structure of Linked List
        // Add just flag to It
        public bool DetectLoopWithFlag(SingleNodeLoop head)
        {
            while(head != null)
            {
                if (head.Flag == 1) return true;

                head.Flag = 1;
                head = (SingleNodeLoop)head.NextNode;
            }


            return false;
        }

        // Loop detection with Floyd’s Cycle-Finding Algorithm:
        /** Approach: This is the fastest method and has been described below:  
         * Traverse linked list using two pointers.
         * Move one pointer(slow_p) by one and another pointer(fast_p) by two.
         * If these pointers meet at the same node then there is a loop. If pointers do not meet then linked list doesn’t have a loop.
        */

        public bool DetectLoopFloydCircle()
        {
            SingleNode slowPointer = _head, fastPointer = _head;

            while(slowPointer != null && fastPointer != null&& fastPointer.NextNode != null)
            {
                slowPointer = slowPointer.NextNode;
                fastPointer = fastPointer.NextNode.NextNode;

                if (slowPointer == fastPointer) return true;
            }

            return false;
        }

        // Return count of nodes in Loop
        public int CountNodeLoop(SingleNode node)
        {
            SingleNode tempNode = node;
            int count = 1;
            while(tempNode.NextNode == node)
            {
                count++;
                tempNode = tempNode.NextNode;
            }

            return count;
        }

        // Find Count node in Loop
        public int CountNodeInLoop(Node list)
        {
            SingleNode slowPointer = _head, fastPointer = _head;

            while (slowPointer != null && fastPointer != null && fastPointer.NextNode != null)
            {
                slowPointer = slowPointer.NextNode;
                fastPointer = fastPointer.NextNode.NextNode;
                if (slowPointer == fastPointer)
                {
                    return CountNodeLoop(slowPointer);
                }
            }

            return -1;
        }

        /**
         * Is linked liste is Palindrom
         * By using Stack we can check
         * Push all object to Stack then Pop and test them
         * 
         */
        public bool IsPolindrom()
        {
            Stack<int> tempStack = new Stack<int>();
            SingleNode tempNode = _head;

            while(tempNode != null)
            {
                tempStack.Push(tempNode.Data);
                tempNode = tempNode.NextNode;
            }

            tempNode = _head;

            while(tempNode != null && tempStack.Count > 0)
            {
                if (tempStack.Pop() != tempNode.Data)
                {
                    return false;
                }
            }


            return true;
        }

        


    }
}



