using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DataStructuresMosh
{
    public class HashTable
    {
        private class Entry
        {
            private int key;
            private string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private List<Entry>[] entries = new List<Entry>[5];

        public void Put(int key, string value)
        {
            var index = Hash(key);
            if (entries[index] == null)
                entries[index] = new List<Entry>();

            List<Entry> bucket = entries[index];

            foreach (var item in bucket)
            {
              
            }

            var entry = new Entry(key, value);
            entries[index].Add(entry);
        }

        private int Hash(int key)
        {
            return key % entries.Length;
        }
    }
}
