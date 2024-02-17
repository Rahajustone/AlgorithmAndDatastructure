using System;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.HashingAlgorithms
{
    public class HashTable
    {
        // To hold key value
        private class Entry
        {
            public int key { get; set; }
            public string value { get; set; }

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int k, string v)
        {
            int index = Hash(k);
            if (entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }

            var bucket = entries[index];
            foreach (var item in bucket)
            {
                if (item.key == k)
                {
                    item.value = v;
                    return;
                }
            }

            var entry = new Entry(k, v);
            entries[index].AddLast(entry);
        }

        public string Get(int k)
        {
            var index = Hash(k);
            var buckets = entries[index];

            if (buckets != null)
            {
                foreach (var item in buckets)
                {
                    if (item.key == k)
                    {
                        return item.value;
                    }
                }
            }

            return null;
        }

        private int Hash(int key)
        {
            return key % entries.Length;
        }

    }
}

