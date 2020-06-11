using System;
using AmazonPrer.DataStructures;
namespace AmazonPrer.Interfaces
{
    public interface ILinkedList
    {
        public void AddItem(Node item);
        public void printAll();
        public Node arrayTolist(int[] item);
    }
}
