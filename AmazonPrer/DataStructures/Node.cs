﻿using System;
using AmazonPrer.Interfaces;
namespace AmazonPrer.DataStructures
{
    public class Node
    {
        //fields
        public Node nextNode;
        public object data;
       

        //Properties
        public void setNodeValue(object v1) { data = v1; }
        public object getNodeValue() { return data; }

        public void setNextNodePointerValue(Node nextNodeAddress) { nextNode = nextNodeAddress; }
        public object getNextNodePointerValue() { return nextNode; }


        //Constructor
        public Node()
        {

        }



    }
}
