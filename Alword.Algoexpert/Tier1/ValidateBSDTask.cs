using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class ValidateBSDTask
    {
        public static bool ValidateBst(BST tree)
        {
            Queue<(BST node, int min, int max)> queue = new Queue<(BST, int, int)>();
            queue.Enqueue((tree, int.MinValue, int.MaxValue));
            while (queue.Count > 0)
            {
                var (node, min, max) = queue.Dequeue();
                if (node.value < min || node.value >= max) return false;
                if (node.left != null)
                {
                    queue.Enqueue((node.left, min, node.value));
                }
                if (node.right != null)
                {
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
