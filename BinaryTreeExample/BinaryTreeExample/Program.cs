using System;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);

            tree.DisplayTree();

            Console.ReadLine();
        }
    }

    public class Node
    {
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;
        }
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class BinaryTree
    {
        private Node _root;

        public BinaryTree()
        {
            _root = null;
        }

        public void Insert (int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            Insert(_root, new Node(data));
        }

        private void Insert(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }
            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    Insert(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    Insert(root.Right, newNode);
                }
            }
             
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;
            DisplayTree(root.Left);
            Console.Write(root.Data + " ");
            DisplayTree(root.Right);

        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
