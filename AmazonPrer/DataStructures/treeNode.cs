using System;
using AmazonPrer.Interfaces;
namespace AmazonPrer.DataStructures
{
    public class treeNode:Itrees
    {
        //define the Properties.
        public int data { get; set; }
        public treeNode leftchild { get; set; }
        public treeNode rightchild { get; set; }

        //Get constructor to initialize the values during instanition
        public treeNode()
        {
            this.data = 0;
            this.leftchild = null;
            this.rightchild = null;
        }

        public treeNode createTreeNode(int data1)
        {
            treeNode temp = new treeNode();
            temp.data = data1;
            return temp;
        }

        public treeNode GenerateTree(int[] data)
        {
            treeNode head = null;
            treeNode nextNode = null;

            foreach(var item in data)
            {
                if(head == null)
                {
                    head = new treeNode().createTreeNode(item);
                }
                else
                {
                    nextNode = head;
                    if(nextNode.leftchild == null)
                    {
                        nextNode.leftchild = new treeNode().createTreeNode(item);
                        continue;
                    }
                    if(nextNode.rightchild == null)
                    {
                        nextNode.rightchild = new treeNode().createTreeNode(item);
                        continue;
                    }

                }

            }

            return head;
        }

        public treeNode insertNode(treeNode tree,int item)
        {
            if (tree == null)
            {
                tree = createTreeNode(item);
                tree.data = item;
            }
            else if(item < tree.data)
            {
                tree.leftchild = this.insertNode(tree.leftchild, item);
            }
            else if(item > tree.data)
            {
                tree.rightchild = this.insertNode(tree.rightchild, item);
            }
                

            return tree;
        }

        public treeNode GenerateTreeFromArray(int[] data)
        {
            treeNode headNode = null;
            

            foreach(var item in data)
            {
         
                headNode = insertNode(headNode,item);

            }

            return headNode;
        }

        public void inorder(treeNode btree)
        {
            if(btree != null)
            {
                inorder(btree.leftchild);
                Console.WriteLine(btree.data);
                inorder(btree.rightchild);
            }                
        }

        public void preorder(treeNode btree)
        {
            if(btree != null)
            {
                Console.WriteLine(btree.data);
                preorder(btree.leftchild);
                preorder(btree.rightchild);
            }

        }

        public void postorder(treeNode btree)
        {
            if(btree != null)
            {
                postorder(btree.leftchild);
                postorder(btree.rightchild);
                Console.WriteLine(btree.data);
            }

        }
    }
}
