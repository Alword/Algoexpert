using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class InvertBinaryTreeTask
    {
        public static void InvertBinaryTree(BinaryTree tree)
        {
            Queue<BinaryTree> swapQueue = new Queue<BinaryTree>();

            swapQueue.Enqueue(tree);
            while (swapQueue.Any())
            {
                var swapRoot = swapQueue.Dequeue();
                if (swapQueue == null) continue;
                if (swapRoot.left != null)
                    swapQueue.Enqueue(swapRoot.left);
                if (swapRoot.right != null)
                    swapQueue.Enqueue(swapRoot.right);
                var left = swapRoot.left;
                swapRoot.left = swapRoot.right;
                swapRoot.right = left;
            }
        }
        public static void Swap()
        {

        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}
