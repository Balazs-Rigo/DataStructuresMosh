using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Expression
    {
        private readonly List<char> leftBrackets = new List<char>() { '(', '<', '[', '{' };
        private readonly List<char> rightBrackets = new List<char>() { ')', '>', ']', '}' };
        public bool isBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var ch in input.ToCharArray())
            {
                if (IsLeftBracket(ch))
                    stack.Push(ch);

                if (IsRightBracket(ch))
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (!BracketsMatch(top, ch)) return false;
                }
            }
            return stack.Count == 0;
        }

        private bool IsLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }

        private bool IsRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(char left, char right)
        {
          return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }

    }
}
