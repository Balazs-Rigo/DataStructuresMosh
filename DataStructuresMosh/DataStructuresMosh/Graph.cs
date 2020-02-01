using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    public class Graph
    {
        public class Node
        {
            public string label;

            public Node(string label)
            {
                this.label = label;
            }

            public override string ToString()
            {
                return label;
            }
        }

        private IDictionary<string,Node> nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

        public void AddNode(string label)
        {
            var node = new Node(label);
            nodes.Add(label,node);
            
            if (!nodes.ContainsKey(label))
                nodes.Add(label,node);

            if (!adjacencyList.ContainsKey(node))
                adjacencyList.Add(node, new List<Node>());
        }

        public void AddEdge(string from, string to)
        {
            var fromNode = nodes[from];
            if (fromNode == null)
                throw new InvalidOperationException("This is not a valid node!");

            var toNode = nodes[to];
            if (toNode == null)
                throw new InvalidOperationException("This is not a valid node!");
            
            adjacencyList[fromNode].Add(toNode);
        }

        public void Print()
        {
            foreach (var source in adjacencyList.Keys)
            {
                var targets =adjacencyList[source];
                if(targets.Count!=0)
                    Console.WriteLine(source+" is connected to "+targets);
            }
        }

        public void RemoveNode(string label)
        {
            var node = nodes[label];
            if (node == null)
                return;

            foreach (var n in adjacencyList.Keys)
                adjacencyList[n].Remove(node);

            adjacencyList.Remove(node);
            nodes.Remove(label);
        }

        public void RemoveEdge(string from, string to)
        {
            var fromNode = nodes[from];
            var toNode = nodes[to];

            if (fromNode == null || toNode == null)
                return;

            adjacencyList[fromNode].Remove(toNode);
        }

        public void TraverseDepthFirst(string root)
        {
            var node = nodes[root];

            if (node == null)
                return;

            TraverseDepthFirstRec(node,new HashSet<Node>());
        }

        private void TraverseDepthFirstRec(Node root,ISet<Node> visited)
        {
            Console.WriteLine(root);
            visited.Add(root);

            foreach (var node in adjacencyList[root])
            {
                if (!visited.Contains(node))
                    TraverseDepthFirstRec(node, visited);
            }
        }

        public void TraverseDephtFirst(string root)
        {
            var node = nodes[root];
            if (node == null)
                return;

            ISet<Node> visited = new HashSet<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Count!=0)
            {
                var current = stack.Pop();

                if (visited.Contains(current))
                    continue;

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var neighbour in adjacencyList[current])
                {
                    if (!visited.Contains(neighbour));
                        stack.Push(neighbour);
                }
            }
        }

        public void TraverseBreadthFirst(string root)
        {
            var node = nodes[root];
            if (node == null)
                return;

            ISet<Node> visited = new HashSet<Node>();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count !=0)
            {
                var current = queue.Dequeue();

                if (visited.Contains(current))
                    continue;

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var neighbour in adjacencyList[current])
                {
                    if (!visited.Contains(neighbour))
                        queue.Enqueue(neighbour);
                }
            }
        }

        public List<string> TopologicalSort()
        {
            Stack<Node> stack = new Stack<Node>();
            ISet<Node> visited = new HashSet<Node>();

            foreach (var node in nodes.Values)
            TopologicalSort(node,visited,stack);

            List<string> sorted = new List<string>();
            while (stack.Count!= 0)
                sorted.Add(stack.Pop().label);
                                 
            return sorted;

        }

        private void TopologicalSort(Node node, ISet<Node> visited, Stack<Node> stack)
        {
            if (visited.Contains(node))
                return;

                visited.Add(node);

            foreach (var neighbour in adjacencyList[node])
                TopologicalSort(neighbour,visited,stack);

            stack.Push(node);
         
        }

        public bool HasCycle()
        {
            ISet<Node> all = new HashSet<Node>();


        }
    }
}
