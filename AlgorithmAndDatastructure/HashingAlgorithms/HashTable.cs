using System;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.HashingAlgorithms
{
    // To hold key value
    public class Entry
    {
        public object key { get; set; }
        public object value { get; set; }

        public Entry(object key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public class HashTable
    {
        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(object k, object v)
        {
            int index = Hash(k);
            if (entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }

            var bucket = entries[index];
            foreach (Entry item in bucket)
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

        public object Get(object k)
        {
            var index = Hash(k);
            var buckets = entries[index];

            if (buckets != null)
            {
                foreach (Entry item in buckets)
                {
                    if (Object.Equals(item.key, k))
                    {
                        return item.value;
                    }
                }
            }

            return null;
        }

        private int Hash(object key)
        {
            return key.GetHashCode() % entries.Length;
        }

    }
}

