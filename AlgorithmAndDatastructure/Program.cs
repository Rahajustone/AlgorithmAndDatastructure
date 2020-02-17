using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using AlgorithmAndDatastructure.LinkedListAlgorithms;
using AlgorithmAndDatastructure.NumericalAlgorithms;
using AlgorithmAndDatastructure.SearchingAlgorithms;

namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.Append(1);
            a.Append(2);
            a.Append(3);
            a.Append(4);
            a.Append(5);

            //a.PrintNode();

            Console.WriteLine(a.CountNode());
            Console.Read();
        }
    }
}
