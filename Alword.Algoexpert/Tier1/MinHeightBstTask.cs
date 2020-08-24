using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class MinHeightBstTask
    {
        public static BST MinHeightBst(List<int> array)
        {
            return Insert(array, 0, array.Count-1);
        }
        private static BST Insert(List<int> array, int left, int right)
        {
            if (left > right)
                return null;
            if (left == right)
                return new BST(array[left]);

            int center = (left + right) / 2;
            BST currentRoot = new BST(array[center]);
            currentRoot.left = Insert(array, left, center - 1);
            currentRoot.right = Insert(array, center + 1, right);
            return currentRoot;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }

            public void insert(int value)
            {
                if (value < this.value)
                {
                    if (left == null)
                    {
                        left = new BST(value);
                    }
                    else
                    {
                        left.insert(value);
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = new BST(value);
                    }
                    else
                    {
                        right.insert(value);
                    }
                }
            }
        }
    }
}
