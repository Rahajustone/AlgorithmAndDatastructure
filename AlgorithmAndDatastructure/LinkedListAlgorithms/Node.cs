using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms
{
    public class Node
    {
        public Node next;
        public int Data { get; }

        public Node(int data)
        {
            this.Data = data;
        }

        // Let's iterate Node
        public void IterateNode(Node node)
        {
            while (node.next != null)
            {
                Console.WriteLine(node.Data);
                node = node.next;
            }
        }
    }
}
