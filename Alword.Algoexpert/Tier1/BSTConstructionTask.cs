using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class BSTConstructionTask
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

            public BST Insert(int value)
            {
                if (value >= this.value)
                {
                    if (this.right == null)
                    {
                        this.right = new BST(value);
                    }
                    else
                    {
                        this.right.Insert(value);
                    }
                }
                else
                {
                    if (this.left == null)
                    {
                        this.left = new BST(value);
                    }
                    else
                    {
                        this.left.Insert(value);
                    }
                }
                return this;
            }

            public bool Contains(int value)
            {
                if (value == this.value)
                    return true;
                else
                if (value >= this.value)
                {
                    if (this.right == null)
                        return false;
                    else
                        return this.right.Contains(value);
                }
                else
                {
                    if (this.left == null)
                        return false;
                    else
                        return this.left.Contains(value);
                }
            }

            public BST Remove(int value)
            {
                Remove(null, value);
                return this;
            }

            private void Remove(BST parent, int value)
            {
                if (value < this.value)
                {
                    if (left != null)
                    {
                        left.Remove(this, value);
                    }
                }
                else if (value > this.value)
                {
                    if (right != null)
                    {
                        right.Remove(this, value);
                    }
                }
                else
                {
                    if (left != null && right != null)
                    {
                        this.value = right.Min();
                        right.Remove(this, this.value);
                    }
                    else if (parent == null)
                    {
                        if (left != null)
                        {
                            this.value = left.value;
                            right = left.right;
                            left = left.left;
                        }
                        else if (right != null)
                        {
                            this.value = right.value;
                            left = right.left;
                            right = right.right;
                        }
                        else
                        {

                        }
                    }
                    else if (parent.left == this)
                    {
                        parent.left = left != null ? left : right;
                    }
                    else if (parent.right == this)
                    {
                        parent.right = left != null ? left : right;
                    }
                }
            }
            private int Min()
            {
                if (left == null)
                    return this.value;
                else
                    return this.left.Min();
            }
        }
    }
}
