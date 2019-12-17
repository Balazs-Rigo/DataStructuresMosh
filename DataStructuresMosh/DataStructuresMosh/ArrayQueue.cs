using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class ArrayQueue
    {
        private int[] items;
        private int rear;
        private int count;
        private int front;

        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (count == items.Length)
                throw new InvalidOperationException();

            items[rear++] = item;
            count++;
        }

        public int Dequeue()
        {
            var item = items[front];
            items[front++] = 0;
            count--;
            return item;
        }

        public override string ToString()
        {
            return string.Join(',', items);
        }


    }
}
