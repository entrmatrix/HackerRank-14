using System;
using System.Collections.Generic;

namespace even_tree
{
    class Node<T>
    {
        public List<Node<T>> children;
        public T value;

        public Node(T val)
        {
            this.value = val;
            children = new List<Node<T>>();
        }

        public int NumChildren()
        {
            int sum = 0;
            foreach (Node<T> n in children)
            {
                sum += n.NumChildren() + 1;
            }

            return sum;
        }

        public Node<T> Find(T val)
        {
            if (this.value.Equals(val))
                return this;

            //check our children
            Node<T> result;
            foreach (Node<T> n in children)
            {
                result = n.Find(val);
                if (result != null)
                {
                    return result;
                }
            }

            //node not found within this sub-tree
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            int edges = Int32.Parse(data[1]);

            Node<int> rootNode = new Node<int>(1);

            //populate tree
            while (edges-- > 0)
            {
                string[] edge = Console.ReadLine().Split();

                int childValue = Int32.Parse(edge[0]), parentValue = Int32.Parse(edge[1]);

                Node<int> pNode = rootNode.Find(parentValue);
                Debug.Assert(pNode != null); //parents should already exist in the tree

                pNode.children.Add(new Node<int>(childValue));
            }

            //solution:
            //transverse each node in the tree. For each child c of parent p, if the child subtree contains
            //an even number of nodes then the edge <c,p> can be removed.
            Console.WriteLine(solve(rootNode));
        }

        static int solve(Node<int> rootNode)
        {
            int removedEdges = 0;

            foreach (Node<int> n in rootNode.children)
            {
                if ((n.NumChildren() + 1) % 2 == 0)
                    removedEdges++;

                removedEdges += solve(n);
            }
            return removedEdges;
        }
    }
}
