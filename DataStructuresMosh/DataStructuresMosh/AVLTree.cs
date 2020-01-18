using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class AVLTree
    {
        public class AVLNode
        {
            public int Height;
            public int Value;
            public AVLNode LeftChild;
            public AVLNode RightChild;

            public AVLNode(int value)
            {
                this.Value = value;
            }

            public override string ToString()
            {
                return "Value: " + this.Value;
            }
        }

        private AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
                return new AVLNode(value);

            if (value < root.Value)
                root.LeftChild = Insert(root.LeftChild, value);
            else
                root.RightChild = Insert(root.RightChild, value);

            SetHight(root);

            return Balance(root);
        }

        private AVLNode Balance(AVLNode node)
        {
            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.LeftChild) < 0)
                   root.LeftChild = RotateLeft(root.LeftChild);
                return rotateRight(root);
            }
            else if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.RightChild) > 0)
                    root.RightChild = rotateRight(root.RightChild);
                return RotateLeft(root);
            }
            return root;          
        }

        private bool IsLeftHeavy(AVLNode node)
        {
            return BalanceFactor(node) > 1;
        }

        private bool IsRightHeavy(AVLNode node)
        {
            return BalanceFactor(node) < -1;
        }

        private int BalanceFactor(AVLNode node)
        {
            return (node == null) ? 0 : Height(node.LeftChild) - Height(node.RightChild);
        }

        private int Height(AVLNode node)
        {
            return (node == null) ? -1 : node.Height;
        }

        private AVLNode RotateLeft(AVLNode root)
        {
            var newRoot = root.RightChild;

            root.RightChild = newRoot.LeftChild;
            newRoot.LeftChild = root;

            SetHight(root);
            SetHight(newRoot);

            return newRoot;
        }

        private AVLNode rotateRight(AVLNode node)
        {
            var newRoot = root.LeftChild;

            root.LeftChild = newRoot.RightChild;
            newRoot.RightChild = root;

            SetHight(root);
            SetHight(newRoot);

            return newRoot;
        }

        private void SetHight(AVLNode node)
        {
           node.Height = Math.Max(Height(root.LeftChild), Height(root.RightChild) + 1);
        }
    }
}

