using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public static class StringReverser
    {
        public static string Reverse(string input)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            //foreach (char item in input.ToCharArray())
            //{
            //    stack.Push(item);
            //}

            StringBuilder reversed = new StringBuilder();
            while (stack.Count!=0)
            {
                reversed.Append(stack.Pop());
            }

            return reversed.ToString();
        }
    }
}
