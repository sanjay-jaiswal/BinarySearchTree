using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
       /// <summary>
       /// Getting and setting nodedata.
       /// </summary>
        public T NodeData
        {
            get;
            set;
        }

       /// <summary>
       /// Getting and setting the left tree.
       /// </summary>
        public BinarySearchTree<T> leftTree { get; set; }


        /// <summary>
        /// Getting and setting the right tree.
        /// </summary>
        public BinarySearchTree<T> rightTree { get; set; }


        /// <summary>
        /// Initializing the nodeDat,left tree and right tree.
        /// </summary>
        /// <param name="nodeData"></param>
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;


        /// <summary>
        /// Insert a element into bst.
        /// </summary>
        /// <param name="item"></param>
        public void InsertNode(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.InsertNode(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.InsertNode(item);
            }
        }

        /// <summary>
        /// Displaying the BST(nodes).
        /// </summary>
        public void DisplayMethod()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.DisplayMethod();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.DisplayMethod();
            }
        }

        /// <summary>
        /// Get the size of BST.
        /// </summary>
        public void GetSizeOfTree()
        {
            Console.WriteLine("Size of binary search tree is : " + (1 + this.leftCount + this.rightCount +"\n"));
        }

        /// <summary>
        /// Searching a node in BST.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool CheckExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element found in the binary search tree : " + node.NodeData);
                return true;
            }
            else
                Console.WriteLine("Current node in BST is : " + node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                CheckExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                CheckExists(element, node.rightTree);
            return true;
        }
    }
}
