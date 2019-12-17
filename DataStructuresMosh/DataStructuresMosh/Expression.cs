using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Expression
    {
        public static bool isBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in input.ToCharArray())
            {
                if (item == '(')
                    stack.Push(item);

                if (item == ')')
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

    }
}
