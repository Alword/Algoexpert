using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class VakudateBSDTask
    {
        public static bool ValidateBst(BST tree)
        {
            Queue<(BST node, int min, int max)> queue = new Queue<(BST, int, int)>();
            queue.Enqueue((tree, int.MinValue, int.MaxValue));
            while (queue.Count > 0)
            {
                var (node, min, max) = queue.Dequeue();
                if (node.left != null)
                {
                    if (node.left.value >= node.value || node.left.value <= min) return false;
                    queue.Enqueue((node.left, min, node.value));
                }
                if (node.right != null)
                {
                    if (node.right.value < node.value || node.right.value > max) return false;
                    queue.Enqueue((node.right, node.value, max));
                }
            }
            return true;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}
