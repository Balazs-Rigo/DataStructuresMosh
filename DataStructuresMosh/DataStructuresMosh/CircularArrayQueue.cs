using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class CircularArrayQueue
    {
        private int[] items;
        private int rear;
        private int count;
        private int front;

        public CircularArrayQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (count == items.Length)
                throw new InvalidOperationException();

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public override string ToString()
        {
            return string.Join(',', items);
        }
    }
}
