using System;
namespace AmazonPrer.DataStructures
{
    public class Node
    {
        //fields
        private Node nextNode;
        private object data;

        //Properties
        public void setNodeValue(object v1) { data = v1; }
        public object getNodeValue() { return data; }

        public void setNextNodePointerValue(Node nextNodeAddress) { nextNode = nextNodeAddress; }
        public object getNextNodePointerValue() { return nextNode; }

        public Node()
        {

        }


    }
}
