using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    /// <summary>
    /// DepthFirstSearch
    /// </summary>
    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public List<string> DepthFirstSearch(List<string> array)
        {
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(this);
            while (nodes.Count > 0)
            {
                var point = nodes.Pop();
                array.Add(point.name);
                if (point.children != null)
                {
                    for (int i = point.children.Count - 1; i >= 0; i--)
                    {
                        var child = point.children[i];
                        nodes.Push(child);
                    }
                }
            }
            return array;
        }

        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}
