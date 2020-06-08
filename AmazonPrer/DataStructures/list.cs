using System;
using AmazonPrer.Interfaces;

namespace AmazonPrer.DataStructures
{
    public class list:ILinkedList
    {
        public Node currentNode { get; set; }
        public Node nextNode { get; set; }


        public list()
        {

        }

        public void AddItem(Node item)
        {
            if(this.currentNode == null)
            {
                this.currentNode = item;

            }
            else
            {
                this.nextNode = this.currentNode;
               while(this.nextNode.getNextNodePointerValue() != null)
                {
                    this.nextNode = (AmazonPrer.DataStructures.Node)this.nextNode.getNextNodePointerValue();
                }
                this.nextNode.setNextNodePointerValue(item);
                

            }

        }

        public void printAll()
        {
            Node printnextNode = this.currentNode;
            

            while (printnextNode.getNextNodePointerValue()!= null)
            {
                Console.WriteLine(printnextNode.getNodeValue());
                printnextNode = (AmazonPrer.DataStructures.Node)printnextNode.getNextNodePointerValue();
            }

            Console.WriteLine(printnextNode.getNodeValue());

        }
    }
}
