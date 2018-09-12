using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.ListNodes
{
    class BinarySearchTree
    {
        DoublyListNode root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void createBST(int[] arr)
        {
            int arrLength = arr.Length;

            if (arrLength < 1)
            {
                root = null;
                return;
            }

           for(int k=0; k<arrLength; k++)
            {
                root = Insert(root, arr[k]);
            }

        }

        private DoublyListNode Insert(DoublyListNode root, int num)
        {
            if (root == null)
            {
                root = new DoublyListNode();
                root.read(num);
            }
            else if(num <= root.data)
            {
                root.left = Insert(root.left, num);
            }
            else
            {
                root.right = Insert(root.right, num);
            }
            return root;
        }

        internal void breadthfirstsearchLevelOrderTraversal()
        {
          if(root == null)
            {               
                return;
            }
            Queue<DoublyListNode> queue = new Queue<DoublyListNode>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                DoublyListNode current= queue.Peek();
                Console.WriteLine(current.data);

                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
                queue.Dequeue();
            }
        }

        internal void depthFirstSearchPreOrderTraversal()
        {
            Console.WriteLine("--PreOrder--");
            dfsPreorder(root);
        }

        private void dfsPreorder(DoublyListNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data);
            dfsPreorder(root.left);
            dfsPreorder(root.right);
        }

        internal void depthFirstSearchInOrderTraversal()
        {
            Console.WriteLine("--InOrder--");
            dfsInorder(root);
           
        }

        private void dfsInorder(DoublyListNode root)
        {
            
            if (root == null)
            {
                return;
            }
            dfsInorder(root.left);
            Console.WriteLine(root.data);
            dfsInorder(root.right);
        }

        internal void depthFirstSearchPostOrderTraversal()
        {
            Console.WriteLine("--PostOrder--");
            dfsPostOrder(root);            
        }

        private void dfsPostOrder(DoublyListNode root)
        {
            if (root == null)
            {
                return;
            }
            dfsPostOrder(root.left);           
            dfsPostOrder(root.right);
            Console.WriteLine(root.data);
        }

        public void checkBinarytreeisBST()
        {
            Console.WriteLine(IsBinarySearchTree(root) ? "Correct BST" : "Wrong BST");
            //Other way
            Console.WriteLine(IsBinarySearchTree(root, int.MinValue, int.MaxValue) ? "Correct BST" : "Wrong BST");            
        }

        private bool IsBinarySearchTree(DoublyListNode root, int minValue, int maxValue)
        {
            if (root == null)
                return true;
            if (root.data > minValue && root.data < maxValue && IsBinarySearchTree(root.left, minValue, root.data) && IsBinarySearchTree(root.right, root.data, maxValue))
                return true;
            else
                return false;
        }

        private bool IsBinarySearchTree(DoublyListNode root)
        {
            if (root == null)
                return true;
            if (IsLeftSubtreeisLesser(root.left, root.data) && IsRightSubtreeisGreater(root.right, root.data) && IsBinarySearchTree(root.left) && IsBinarySearchTree(root.right))
                return true;
            else
                return false;
        }      

        private bool IsRightSubtreeisGreater(DoublyListNode right, int data)
        {
            if (right == null)
                return true;
            if (right.data >= data && IsLeftSubtreeisLesser(right.left, right.data) && IsRightSubtreeisGreater(right.right, right.data))
                return true;
            else return false;
        }

        private bool IsLeftSubtreeisLesser(DoublyListNode left, int data)
        {
            if (left == null)
                return true;
            if (left.data <= data && IsLeftSubtreeisLesser(left.left, left.data) && IsRightSubtreeisGreater(left.right, left.data))
                return true;
            else return false;
        }

        internal void DeleteNodeFromBST(int num)
        {
            if(root == null)
                Console.WriteLine("No node exist to delete");
            root = DeleteNodeFromBST(root, num);
        }

        private DoublyListNode DeleteNodeFromBST(DoublyListNode root, int num)
        {
            if (root == null)
                return root;

            if (root.data > num)
                root.left = DeleteNodeFromBST(root.left, num);
            else if (root.data < num)
            {
                root.right = DeleteNodeFromBST(root.right, num);

            }
            else
            {
                if(root.left == null && root.right == null)
                {
                    root = null;
                }
                else if(root.left == null)
                {
                    root = root.right;
                }
                else if(root.right == null)
                {
                    root = root.left;
                }
                else
                {
                    DoublyListNode temp = Findmin(root.right);
                    root.data = temp.data;
                    root.right = DeleteNodeFromBST(root.right, temp.data);
                }                
            }
            return root;
        }

        private DoublyListNode Findmin(DoublyListNode root)
        {
            while(root.left != null)
            {
                root = root.left;
            }
            return root;
        }
    }
}
