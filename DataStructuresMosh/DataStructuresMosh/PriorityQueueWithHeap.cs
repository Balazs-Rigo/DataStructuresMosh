using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class PriorityQueueWithHeap
    {
        private Heap heap = new Heap();

        public void Enqueue(int item)
        {
            heap.Insert(item);
        }

        public int dequeue()
        {
            return heap.Remove();
        }

        public bool IsEmpy()
        {
            return heap.IsEmpty();
        }
    }
}
