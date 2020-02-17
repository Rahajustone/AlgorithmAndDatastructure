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
    }
}
