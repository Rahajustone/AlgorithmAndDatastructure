using Algorithms.Princeton.Unuversity.Connectivity;

class Program
{
    static void Main(string[] args)
    {

        var quickUnion = new QuickUnion(10);
        var r = quickUnion.IsConnected(1, 5);
        Console.WriteLine(r);
        quickUnion.Union(1, 5);
        var res = quickUnion.IsConnected(1, 5);
        Console.WriteLine(r);
        var r1 = quickUnion.IsConnected(2, 3);
        var r2 = quickUnion.IsConnected(4, 3);
        var r3 = quickUnion.IsConnected(5, 1);

        Console.WriteLine(r1);
        Console.WriteLine(r2);
        Console.WriteLine(r3);


    }
}