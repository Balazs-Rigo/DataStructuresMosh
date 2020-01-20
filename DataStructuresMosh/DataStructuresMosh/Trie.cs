using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Trie
    {
        private class Node
        {
            public static int ALPHABET_SIZE = 26;
            public char value;
            public Dictionary<char, Node> children = new Dictionary<char, Node>();
            public bool IsEndOfWord;

            public Node(char value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "value: " + value;
            }

            public bool HasChild(char ch)
            {
                return children.ContainsKey(ch);
            }

            public void AddChild(char ch)
            {
                children.Add(ch,new Node(ch));
            }

            public Node  GetChild(char ch)
            {
                return children[ch];
            }            

            public Node[] GetChildren()
            {
               var arr = new Node[3];
               children.Values.CopyTo(arr,0);
               return arr;
            }

            public bool HasChild()
            {
                return children.Count != 0;
            }

            public void RemoveChild(char ch)
            {
                children.Remove(ch);
            }
        }

        private Node root = new Node(' ');

        public void Insert(string word)
        {
            var current = root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.HasChild(ch))
                    current.AddChild(ch);
                current = current.GetChild(ch);
            }
            current.IsEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (word == null)
                return false;

            var current = root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.HasChild(ch))
                    return false;

                current = current.GetChild(ch);
            }
            return current.IsEndOfWord;
        }

        public void Traverse()
        {
            Traverse(root);
        }

        private void Traverse(Node root)
        {
            Console.WriteLine(root.value);

            foreach (var child in root.GetChildren())
            {                
                if (child == null)
                    return;
                Traverse(child);
            }
        }

        public void Remove(string word)
        {
            if (word == null)
                return;

            Remove(root,word,0);
        }

        private void Remove(Node root, string word, int index)
        {
            if(index == word.Length)
            {
                root.IsEndOfWord = false;
                return;
            }

            var ch = word[index];
            var child = root.GetChild(ch);
            if (child == null)
                return;

            Remove(child, word, index + 1);

            if (!child.HasChild() && !child.IsEndOfWord)
                root.RemoveChild(ch);
        }
        public List<string> FindWords(string prefix)
        {
            List<string> words = new List<string>();
            var lastNode = FindLastNodeOf(prefix);
            FindWords(lastNode,prefix, words);

            return words;
        }

        private void FindWords(Node root, string prefix, List<string> words)
        {
            if (root == null)
                return;

            if (root.IsEndOfWord)
                words.Add(prefix);

            foreach (var child in root.GetChildren())
            {
                FindWords(child,prefix+child.value,words);
            }
        }

        private Node FindLastNodeOf(string prefix)
        {
            if (prefix == null)
                return null; 

            var current = root;
            foreach (var ch in prefix.ToCharArray())
            {
                var child = current.GetChild(ch);
                if (child == null)
                    return null;
                current = child;
            }
            return current;
        }
    }
}
