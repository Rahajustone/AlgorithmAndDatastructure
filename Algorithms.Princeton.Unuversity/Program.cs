using Algorithms.Princeton.Unuversity.Connectivity;
using Algorithms.Princeton.Unuversity.QueueCustom;

class Program
{
    static void Main(string[] args)
    {
        var queue = new CustomQueueWithLinkedList<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();

        queue.PrintQueue();

    }
}