using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class NodeDepthsTask
    {
        public static int NodeDepths(BinaryTree root)
        {
            int sum = 0;
            Stack<BinaryTree> points = new Stack<BinaryTree>();
            points.Push(root);
            root.value = 0;
            while (points.Count > 0)
            {
                var point = points.Pop();
                if (point.right != null || point.left != null)
                {
                    if (point.right != null)
                    {
                        point.right.value = point.value + 1;
                        points.Push(point.right);
                    }
                    if (point.left != null)
                    {
                        point.left.value = point.value + 1;
                        points.Push(point.left);
                    }
                }
                sum += point.value;
            }
            return sum;
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
    }
}
