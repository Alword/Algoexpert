using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class FindClosestValueInBst
    {
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
        public int Solve(BST tree, int target)
        {
            int dif = Math.Abs(tree.value - target);
            int closest = tree.value;

            do
            {
                if (tree.left != null && tree.value > target)
                    tree = tree.left;
                else if (tree.right != null && tree.value < target)
                    tree = tree.right;
                else 
                {
                    return closest;
                }

                var newDif = Math.Abs(tree.value - target);
                if (newDif < dif)
                {
                    dif = newDif;
                    closest = tree.value;
                }

            }
            while (closest != 0);
            return closest;
        }
    }
}
