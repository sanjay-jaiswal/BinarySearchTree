using System;

namespace Day17_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================ Welcome To Binary Search Tree (BST) Program ==========================");
            Console.WriteLine("Inserted nodes are : ");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.InsertNode(30);
            binarySearchTree.InsertNode(70);
            binarySearchTree.DisplayMethod();
        }
    }
}
