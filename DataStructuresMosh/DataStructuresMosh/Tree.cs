using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Tree
    {
        public class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "Node= " + value;
            }
        }

        private Node root;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value < current.value)
                    current = current.leftChild;
                else if (value > current.value)
                    current = current.rightChild;
                else
                    return true;
            }
            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node root)
        {
            if (root == null)
                return;

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null)
                return;

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        public int Height()
        {
            return Height(root);
        }
        private int Height(Node root)
        {
            if (root == null)
                return -1;

            if (IsLeaf(root))
                return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        public int Min()
        {
            return Min(root);
        }

        private int Min(Node root)
        {
            if (IsLeaf(root))
                return root.value;

            var left = Min(root.leftChild);
            var right = Min(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value);
        }

        public bool Equals(Tree other)
        {
            if (other == null)
                return false;

            return Equals(root, other.root);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
               return true;

            if (first != null && second != null)
                return first.value == second.value
                    && Equals(first.leftChild, second.leftChild)
                    && Equals(first.rightChild, second.leftChild);

            return false;
        }

        public void SwapRoot()
        {
            var temp = root.leftChild;
            root.leftChild = root.rightChild;
            root.rightChild = temp;
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.value < min || root.value > max)
                return false;

           return IsBinarySearchTree(root.leftChild, min, root.value-1)
                && IsBinarySearchTree(root.rightChild,root.value+1, max);
        }

        public List<int> GetNodeAtDistance(int distance)
        {
            var list = new List<int>();
            GetNodeAtDistance(root,distance,list);
            return list;
        }

        private void GetNodeAtDistance(Node root, int distance, List<int> list)
        {
            if (root == null)
                return;

            if (distance == 0) 
            {
                list.Add(root.value);
                return;
            }

            GetNodeAtDistance(root.leftChild, distance - 1,list);
            GetNodeAtDistance(root.rightChild, distance - 1,list);

        }
    }
}
