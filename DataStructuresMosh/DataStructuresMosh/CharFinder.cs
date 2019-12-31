using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class CharFinder
    {
        public char FindFirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            var chars = str.ToCharArray();
            foreach (var ch in chars)
            {
                var count = map.ContainsKey(ch) ? map[ch] : 0;
                map.Add(ch,count+1);
            }

            foreach (var ch in chars)
            {
                if (map[ch] == 1)
                    return ch;
            }

            Console.WriteLine(string.Join(',',map));

            return Char.MinValue;
        }

        public char FindFirstRepeatedChar(string str)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (var ch in str.ToCharArray())
            {
                if (set.Contains(ch))
                    return ch;

                set.Add(ch);
            }

            return char.MinValue;
        }
    }
}
