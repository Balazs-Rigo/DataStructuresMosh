using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DataStructuresMosh
{
    public class Stack
    {
        private int[] items = new int[5];
        private int count;

        public void push(int item)
        {
            if (count == items.Length)
                throw new IndexOutOfRangeException();

            items[count++] = item;
        }

        public int pop()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[count--];
        }

        public int peek()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[count-1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            int[] content = new int[count];
            System.Array.Copy(items, content, count);
            return string.Join(',', content);
        }
    }
}
