﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
    public class BranchSumsTask
    {
        public static List<int> BranchSums(BinaryTree root)
        {
            List<int> reuslt = new List<int>();
            Stack<BinaryTree> points = new Stack<BinaryTree>();
            points.Push(root);
            while (points.Count > 0)
            {
                var point = points.Pop();
                if (point.right != null || point.left != null)
                {
                    if (point.right != null)
                    {
                        point.right.value += point.value;
                        points.Push(point.right);
                    }
                    if (point.left != null)
                    {
                        point.left.value += point.value;
                        points.Push(point.left);
                    }
                }
                else reuslt.Add(point.value);
            }
            return reuslt;
        }
    }
}
