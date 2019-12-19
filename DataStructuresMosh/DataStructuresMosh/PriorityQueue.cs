using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class PriorityQueue
    {
        private int[] items = new int[5];
        private int count;

        public void Add(int item)
        {

            if (IsFull())
                throw new InvalidOperationException();

            var i = ShiftItemsToInsert(item);

            items[i] = item;
            count++;
        }

        public bool IsFull()
        {
            return count == items.Length;
        }

        public int Remove()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[--count];
        }

        public int ShiftItemsToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                    items[i + 1] = items[i];
                else
                    break;
            }
            return i+1;
        }

        public override string ToString()
        {
            return string.Join(',',items);
        }
    }
}
