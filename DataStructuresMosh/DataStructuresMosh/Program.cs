using System;
using System.Collections.Generic;

namespace DataStructuresMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sajat array
            //int[] numbers = new int[10] {12,56,834,99,23,81,654,8,12,546 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);                
            //}
            #endregion

            #region Mosh array
            /*Array number = new Array(3);
            number.print();
            number.Insert(10);
            number.Insert(20);
            number.Insert(30);
            number.Insert(40);
            number.Insert(50);
            number.removeAt(0);
            Console.WriteLine("indexOf: "+number.indexOf(20));
            number.print();*/
            #endregion

            #region mosh linked list

            //LinkedList list = new LinkedList();
            //list.AddLast(14);
            //list.AddLast(22);
            //list.AddLast(31);
            //list.AddLast(77);
            //list.AddLast(11);
            //list.AddLast(42);

            //int[] listArray = list.toArray();

            //foreach (var item in listArray)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Get k-1: "+list.GetKthMinus1(3));
            //Console.WriteLine("Get k: " + list.GetKthFromTheEnd(3));


            //Console.ReadLine();

            #endregion

            #region reversing string
            //Console.WriteLine(StringReverser.Reverse("Nincs itt hideg?"));
            //Console.WriteLine(Expression.isBalanced("((2+2)*(4+4))"));
            //Console.ReadLine();

            #endregion

            #region stack
            //Stack stack = new Stack();
            //stack.push(10);
            //stack.push(20);
            //stack.push(30);

            //stack.pop();

            //Console.WriteLine(stack.ToString());

            //Console.ReadLine();
            #endregion

            #region queue
            //System.Collections.Generic.Queue<int> queue = new System.Collections.Generic.Queue<int>();
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);

            //ArrayQueue queue = new ArrayQueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //var front = queue.Dequeue();

            //Console.WriteLine(front);
            //Console.WriteLine(queue.ToString());
            ////Queue.Reverse(queue);

            //Console.ReadLine();
            #endregion

            #region CircualArrayqueue
            //System.Collections.Generic.Queue<int> queue = new System.Collections.Generic.Queue<int>();
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);

            //CircularArrayQueue queue = new CircularArrayQueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //var front = queue.Dequeue();
            //queue.Dequeue();
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //queue.Enqueue(60);
            //queue.Enqueue(70);
            //queue.Dequeue();
            //queue.Dequeue();

            //Console.WriteLine(front);
            //Console.WriteLine(queue.ToString());
            ////Queue.Reverse(queue);

            //Console.ReadLine();
            #endregion

            #region Queue with two stacks
            //QueueWithTwoStacks queue = new QueueWithTwoStacks();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //var first = queue.Dequeue();
            //Console.WriteLine(first);

            #endregion

            #region PriorityQueue
            //PriorityQueue queue = new PriorityQueue();
            //queue.Add(5);
            //queue.Add(3);
            //queue.Add(6);
            //queue.Add(1);
            //queue.Add(4);
            //queue.Add(10);
            //Console.WriteLine(queue);
            #endregion

            #region HashTable
            //Dictionary<int?, string> map = new Dictionary<int?, string>();
            //map.Add(1, "Mosh");
            //map.Add(2, "John");
            //map.Add(3, "Mary");
            //map.Add(4, null);
            //Console.WriteLine(string.Join(' ', map));

            #endregion

            #region Dictionary and Set
            //CharFinder finder = new CharFinder();
            //var ch = finder.FindFirstRepeatedChar("a green apple");

            //Console.WriteLine(ch);

            #endregion

            #region tree
            /*Tree tree = new Tree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            //tree.Insert(22);
            //tree.Insert(11);
            //tree.Insert(3);

            Tree tree2 = new Tree();
            tree2.Insert(7);
            tree2.Insert(4);
            tree2.Insert(9);
            tree2.Insert(1);
            tree2.Insert(6);
            //tree2.Insert(22);
            //tree2.Insert(11);
            //tree2.Insert(3);

            Console.WriteLine(tree.Find(6));
            Console.WriteLine();
            Console.WriteLine("Pre-order: ");
            tree.TraversePreOrder();
            Console.WriteLine();
            Console.WriteLine("In-order: ");
            tree.TraverseInOrder();
            Console.WriteLine();
            Console.WriteLine("Post-order: ");
            tree.TraversePostOrder();
            Console.WriteLine();
            Console.WriteLine("Height of the tree is: "+tree.Height());
            Console.WriteLine("Min value is: "+tree.Min());
            Console.WriteLine("A ket fa egyenlo: "+tree.Equals(tree2));
            tree.SwapRoot();
            Console.WriteLine("Is binary search tree: "+tree.IsBinarySearchTree());
            var list = tree.GetNodeAtDistance(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Done");*/
            #endregion

            #region recursion
            //int fact = Recursion.factorial(4);
            //Console.WriteLine(fact);
            #endregion

            #region AVL trees
            //var tree = new AVLTree();
            //tree.Insert(10);
            //tree.Insert(20);
            //tree.Insert(30);
            //tree.Insert(40);
            //tree.Insert(50);
            //tree.Insert(60);
            #endregion

            #region Heap
            //var heap = new Heap();
            //heap.Insert(10);
            //heap.Insert(5);
            //heap.Insert(17);
            //heap.Insert(4); 
            //heap.Insert(22);
            //Console.WriteLine(heap.Remove());
            //Console.WriteLine(heap.Remove());
            //Console.WriteLine("Done!");
            #endregion

            #region heapify
            //int[] numbers = {5,3,8,4,1,2 };
            //Console.WriteLine(MaxHeap.GetKthLargest(numbers,4));
            #endregion

            #region Trie
            //var trie = new Trie();
            //trie.Insert("car");
            //trie.Insert("care");
            //trie.Insert("card");
            //trie.Insert("careful");
            //trie.Insert("egg");
            //var words = trie.FindWords("care");
            //Console.WriteLine(words);
            //Console.WriteLine("Done!");
            #endregion

            #region Graph
            var graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddEdge("A","B");
            graph.AddEdge("A", "C");
            graph.AddEdge("D", "C");
            graph.AddEdge("A", "C");
            graph.TraverseDepthFirst("A");

            graph.Print();
            #endregion

            Console.ReadLine();
        }

        public void log(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }
    }
}
