using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class LinkedList
    {
        private class Node
        {
            public int value;
            public  Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current.next != null)
            {
                if (current.value == item) return index;
                index++;
                current = current.next;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFrist()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();

            if (first == last)
                first = last = null;
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();

            if (first == last)           
                first = last = null;
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }          
            size--;
        }

        public int Size()
        {
            return size;
        }

        public int[] toArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }

        public void Reverse()
        {
            if (IsEmpty()) return;

            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        public int GetKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            var a = first;
            var b = first;
            for (int i = 0; i < k-1; i++)
            {
                b = b.next;
                if (b == null)
                    throw new ArgumentOutOfRangeException();
            }

            while (b != last)
            {
                a = a.next;
                b = b.next;
            }
            return a.value;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current.next != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        private bool IsEmpty()
        {
            return first == null;
        }
    }
}
