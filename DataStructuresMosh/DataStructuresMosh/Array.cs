using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Array
    {
        private int[] _items;
        private int count;
        public Array(int length)
        {
            _items = new int[length];
        }

        public void Insert(int item)
        {
            if (_items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                    newItems[i] = _items[i];

                _items = newItems;
            }

            _items[count++] = item;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            for (int i = index; i < count; i++)
                _items[i] = _items[i+1];

            count--;
        }

        public int indexOf(int item)
        {
            for (int i = 0; i < count; i++)
                if (_items[i] == item)
                    return i;

            return -1;
        }

        public void print() 
        {
            for (int i= 0;  i< count; i++)
                Console.WriteLine(_items[i]);
        }

    }
}
