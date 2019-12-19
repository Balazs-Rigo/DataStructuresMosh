using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class QueueWithTwoStacks
    {
        private System.Collections.Generic.Stack<int> stack1 = new Stack<int>();
        private System.Collections.Generic.Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int item)
        {
            stack1.Push(item);

        }

        public int Dequeue()
        {
            if (Isempty())
                throw new InvalidOperationException();
            
            MoveStack1ToStack2();

            return stack2.Pop();
        }

        public int Peek()
        {
            if (Isempty())
                throw new InvalidOperationException();

            MoveStack1ToStack2();

            return stack2.Peek();
        }

        private void MoveStack1ToStack2()
        {
            if (stack2.Count == 0)
                while (stack1.Count != 0)
                    stack2.Push(stack1.Pop());
        }

        private bool Isempty()
        {
            return stack1.Count == 0 && stack2.Count == 0;              
        }

    }
}
