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

            for (int k = 0; k < arrLength; k++)
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
            else if (num <= root.data)
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
            if (root == null)
            {
                return;
            }
            Queue<DoublyListNode> queue = new Queue<DoublyListNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                DoublyListNode current = queue.Peek();
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

        internal void SpiralTraversal()
        {
            if (root == null)
                return;

            Stack<DoublyListNode> S1 = new Stack<DoublyListNode>();
            Stack<DoublyListNode> S2 = new Stack<DoublyListNode>();
            DoublyListNode P = null;

            S1.Push(root);

            while (S1.Count != 0 || S2.Count != 0)
            {
                while (S1.Count != 0)
                {
                    P = S1.Pop();
                    Console.WriteLine(P.data);
                    if (P.left != null)
                        S2.Push(P.left);
                    if (P.right != null)
                    {
                        S2.Push(P.right);
                    }
                }
                while (S2.Count != 0)
                {
                    P = S2.Pop();
                    Console.WriteLine(P.data);
                    if (P.right != null)
                        S1.Push(P.right);
                    if (P.left != null)
                        S1.Push(P.left);
                }
            }
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
            if (root == null)
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
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else if (root.left == null)
                {
                    root = root.right;
                }
                else if (root.right == null)
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
            while (root.left != null)
            {
                root = root.left;
            }
            return root;
        }

        internal void GetInorderSuccessor(int num)
        {
            if (root == null)
            {
                Console.WriteLine("Empty tree");
            }
            DoublyListNode successor = FindInorderSuccessor(root, num);
            Console.WriteLine("InorderSuccessor of 8 is :" + successor != null ? successor.data : 0);
        }

        private DoublyListNode FindInorderSuccessor(DoublyListNode root, int num)
        {
            DoublyListNode current = FindValueInTree(root, num);
            if (current == null)
                return null;

            if (current.right != null)
            {
                return Findmin(current.right);
            }
            else
            {
                DoublyListNode ancestor = root;
                DoublyListNode successor = null;
                while (current != ancestor)
                {
                    if (current.data < ancestor.data)
                    {
                        successor = ancestor;
                        ancestor = ancestor.left;
                    }
                    else
                    {
                        ancestor = ancestor.right;
                    }
                }
                return successor;
            }
        }

        private DoublyListNode FindValueInTree(DoublyListNode root, int num)
        {
            if (root.data == num)
            {
                return root;
            }

            if (num < root.data)
            {
                root = FindValueInTree(root.left, num);
            }
            else
            {
                root = FindValueInTree(root.right, num);
            }
            return root;
        }

        internal void FindBSTHeight()
        {
            int height = FindBSTHeight(root);
            Console.WriteLine("Tree height " + height);
        }

        private int FindBSTHeight(DoublyListNode root)
        {
            if (root == null)
            {
                return -1;
            }

            return FindMax(FindBSTHeight(root.left), FindBSTHeight(root.right)) + 1;
        }

        private int FindMax(int leftSubtreeHeight, int rightSubtreeHeight)
        {
            return leftSubtreeHeight > rightSubtreeHeight ? leftSubtreeHeight : rightSubtreeHeight;
        }

        internal bool AreParanthesesBalanced(string expression)
        {
            if (expression == null)
            {
                return true;
            }

            Stack<char> s = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '{' || expression[i] == '(' || expression[i] == '[')
                {
                    s.Push(expression[i]);
                }
                else if (expression[i] == '}' || expression[i] == ')' || expression[i] == ']')
                {
                    if (s.Count == 0 || !ArePair(s.Peek(), expression[i]))
                        return false;
                    else
                        s.Pop();
                }
            }

            return s.Count == 0 ? true : false;
        }

        private bool ArePair(char opening, char closing)
        {
            if (opening == '(' && closing == ')') return true;
            if (opening == '{' && closing == '}') return true;
            if (opening == '[' && closing == ']') return true;

            return false;
        }

        internal int EvaluatePostfix(string exp)
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == ',' || exp[i] == ' ')
                    continue;

                else if (IsOperator(exp[i]))
                {
                    int operand1 = s.Pop();
                    int operand2 = s.Pop();
                    int result = PerformOperation(exp[i], operand1, operand2);

                    s.Push(result);
                }
                else if (IsNumericDigit(exp[i]))
                {
                    // Extract the numeric operand from the string
                    // Keep incrementing i as long as you are getting a numeric digit. 
                    int operand = 0;
                    while (i < exp.Length && IsNumericDigit(exp[i]))
                    {
                        // For a number with more than one digits, as we are scanning from left to right. 
                        // Everytime , we get a digit towards right, we can multiply current total in operand by 10 
                        // and add the new digit. 
                        operand = (operand * 10) + (exp[i] - '0');
                        i++;
                    }
                    // Finally, you will come out of while loop with i set to a non-numeric character or end of string
                    // decrement i because it will be incremented in increment section of loop once again. 
                    // We do not want to skip the non-numeric character by incrementing i twice. 
                    i--;

                    // Push operand on stack. 
                    s.Push(operand);
                }
            }

            // If expression is in correct format, Stack will finally have one element. This will be the output. 
            return s.Peek();

        }

        private bool IsNumericDigit(char C)
        {
            if (C >= '0' && C <= '9')
            {
                return true;
            }

            return false;
        }

        private int PerformOperation(char operation, int operand1, int operand2)
        {
            if (operation == '+') return operand1 + operand2;
            else if (operation == '-') return operand1 - operand2;
            else if (operation == '*') return operand1 * operand2;
            else if (operation == '/') return operand1 / operand2;

            return -1;
        }

        private bool IsOperator(char C)
        {
            if (C == '+' || C == '-' || C == '*' || C == '/') return true;
            else
                return false;
        }


        internal void NumberBinarySearchCanDrawnwithSpecificNumner(int number)
        {
            int[] arr = new int[number];
            arr[0] = 1; arr[1] = 1;

            for (int i = 2; i < number; i++)
            {
                arr[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    arr[i] += arr[j] * arr[i - j - 1];
                }
            }

            Console.WriteLine("With " + number + "We can create " + arr[number - 1] + " BST");
        }

        internal void porintNodeshavingKleaves(int num)
        {
            if (root == null)
                return;
            int count = countLeaves(root, num);
        }

        private int countLeaves(DoublyListNode root, int num)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;

            int lefttreeLeafCount = countLeaves(root.left, num);
            int righttreeleafCount = countLeaves(root.right, num);

            int totalLeafCount = lefttreeLeafCount + righttreeleafCount;

            if (totalLeafCount == num)
                Console.WriteLine(root.data);

            return totalLeafCount;
        }

        internal void LCA()
        {
            DoublyListNode LCANode = LCA(root, 6, 10);
            Console.WriteLine(LCANode.data);
        }

        private DoublyListNode LCA(DoublyListNode root, int p, int q)
        {
            if (root == null)
                return null;
            if (root.data == p || root.data == q)
            {
                return root;
            }

            DoublyListNode left = LCA(root.left, p, q);
            DoublyListNode right = LCA(root.right, p, q);

            if(left != null && right != null)
            {
                return root;
            }
            else
            {
                return left != null ? left : right;
            }
        }
    }
}
