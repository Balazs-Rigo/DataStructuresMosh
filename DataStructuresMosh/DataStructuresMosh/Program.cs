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
            Console.WriteLine(Expression.isBalanced("((2+2)*(4+4))"));
            Console.ReadLine();

            #endregion
        }

        public void log(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }
    }
}
