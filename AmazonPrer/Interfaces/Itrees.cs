using System;
using AmazonPrer.DataStructures;
namespace AmazonPrer.Interfaces
{
    public interface Itrees
    {
        public treeNode createTreeNode(int data);
        public treeNode GenerateTree(int[] data);
        public void inorder(treeNode btree);
        public void preorder(treeNode btree);
        public void postorder(treeNode btree);
    }

}
