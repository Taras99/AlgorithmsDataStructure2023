using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure2022.Binary_tree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert (int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }


        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);
            
            if(node == null)
            {
                node = newNode;
                return node;

                
            }
            if(key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            

            }
            return node;
        }


        public string Find(int key)
        {

            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;


        }

        private TreeNode? Find(TreeNode node, int key) 
        {
            if (node == null || node.Key == key)
            {
                return node;
            }
            else if (key < node.Key)
            {
                return Find(node.LeftChild,key);
            }
            else if (node.Key > key)
            {
                return Find(node.RightChild,key);
            }
            else
            {
                return null;
            }
        }

        public void PrintInOrderTraversal()
        {
            InOrderTraversal(Root);
        }

        public TreeNode InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine(node.Key + " " + node.Value);
                InOrderTraversal(node.RightChild);
            }
            /// ??
            return node;
        }







    }
}
