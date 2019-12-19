using System;

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
            PriorityQueue queue = new PriorityQueue();
            queue.Add(5);
            queue.Add(3);
            queue.Add(6);
            queue.Add(1);
            queue.Add(4);
            queue.Add(10);
            Console.WriteLine(queue);
            #endregion

            Console.ReadLine();
        }

        public void log(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }
    }
}
