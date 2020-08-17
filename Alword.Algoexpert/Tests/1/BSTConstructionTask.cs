using Alword.Algoexpert.Tier1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests._1
{
    public class BSTConstructionTest
    {
        [Fact]
        public void Insertiontest()
        {
            var bst = new BSTConstructionTask.BST(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(13);
            bst.Insert(22);
            bst.Insert(1);
            bst.Insert(14);
            bst.Insert(12);
            bst.Remove(10);
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void Test9()
        {
            var bst = new BSTConstructionTask.BST(10);
            bst.Insert(5);
            bst.Remove(10);
            bst.Contains(15);
        }
}
}
