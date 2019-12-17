using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DataStructuresMosh
{
    public class Queue
    {
        public static void Reverse(Queue<int> queue)
        {
            System.Collections.Generic.Stack<int> stack = new System.Collections.Generic.Stack<int>();
            while (queue.Count != 0)
                stack.Push(queue.Dequeue());
            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
            {

            }
        }
    }
}
