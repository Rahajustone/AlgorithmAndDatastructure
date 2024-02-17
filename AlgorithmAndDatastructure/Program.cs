using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Reflection;
using CustomHashTable = AlgorithmAndDatastructure.HashingAlgorithms;
//using AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom;
//using AlgorithmAndDatastructure.StackCustom;
//using AlgorithmAndDatastructure.Dictionary;

namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //var res = DemoQuestions.FirstRepeatedChar("Test hello my worldT");
            ////Console.WriteLine(res);
            //Console.WriteLine(res.GetHashCode());
            //int a = 10;
            //int b = a;
            //a = 5;
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            Hashtable abc = new Hashtable();
            abc.Add(1, "one");
            abc.Add(2, "two");
            abc.Add(3, null);
            foreach (DictionaryEntry item in abc)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            var customHashTable = new CustomHashTable.HashTable();
            customHashTable.Put(1, "one");
            customHashTable.Put(1, "two");
            customHashTable.Put(1, "Three");

        }
    }
}
