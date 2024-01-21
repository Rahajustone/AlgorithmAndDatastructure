using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom;
namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedListGenerics<string> test = new CustomLinkedListGenerics<string>();
            test.AddFirst("Worlds");
            test.AddFirst("Hello");
            test.AddLast("!");
            test.PrintNodes();
        }
    }
}
