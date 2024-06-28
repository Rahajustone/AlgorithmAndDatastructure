using Algorithms.Princeton.Unuversity.Connectivity;
using Algorithms.Princeton.Unuversity.QueueCustom;

class Program
{
    static void Main(string[] args)
    {
        var queue = new CircularQueue();
        queue.InsertFront(1);
        queue.InsertFront(2);
        //queue.InsertLast(3);
        queue.InsertFront(4);
        queue.InsertFront(5);
        //queue.InsertLast(6);

        queue.PrintAll();
        Console.WriteLine("--------");
        queue.PrintAllFromLast();


    }
}