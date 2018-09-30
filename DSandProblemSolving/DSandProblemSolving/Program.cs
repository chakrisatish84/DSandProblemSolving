using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stringSearch
            //string/pattern search in a text.
            //string strFirst = "abcbcfgm";
            //string strSecond = "bcfgm";

            //string sResult = stringSearchinaText(strFirst, strSecond);
            //BruteForce
            //string sResult = stringSearchinaTextBruteForce(strFirst, strSecond);
            //Console.WriteLine(sResult);
            #endregion

            //Bubble Sort
            #region BubbleSort
            //int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };
            //int[] bubbleSortArray = BubbleSort(arr, arr.Length);
            // Console.WriteLine(string.Join(",", bubbleSortArray));
            #endregion

            //Binary Search
            #region BinarySearch
            //int[] arr = { 2, 5, 7, 11, 12, 15, 20, 30, 34, 36 };
            //int searchElement = Convert.ToInt32(Console.ReadLine());
            //string sResult = BinarySearch(arr, arr.Length, searchElement);
            //Console.WriteLine(sResult);

            //rotated sorted array.
            //int[] arr = { 11, 12, 15, 18, 2, 5, 6, 8 };

            //int result = FindrotaionCount(arr, arr.Length);

            //Search element ins a circular sorted array.

            //int[] arr = { 12, 14, 18, 21, 3, 6, 8, 9 };
            //int result = CircularArraySearch(arr, arr.Length, 18);

            int[] arr = { 2, 4, 1, 6, 8, 5, 3, 7 };
            //MergeSort(arr, arr.Length);
            #endregion

            // singleLinkedList
            //int[] arr = { 2, 5, 7, 11, 12, 15, 20, 30, 34, 36, 30,40 };
            //int[] arr = { 6, 5, 3, 1, 8, 7, 10, 2, 4, 12 };
            ////int[] arr1 = { 10,50,70,90,100 };
            ////int[] arr2 = { 30,40,60,80 };
            ////Add two lists
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 9, 6, 3 };
            //int[] listPallindrome = { 1, 2, 3, 3, 2, 1 };
            //int[] arraywithDuplicates = { 1, 2, 2, 3, 3, 3, 4 };
            //ListNodes.SingleLinkedList singlelinkedList = new ListNodes.SingleLinkedList();
            //singlelinkedList.createSingleLinkedList(arraywithDuplicates);
            ////singlelinkedList.insertatStart(50);
            ////singlelinkedList.insertatEnd(60);
            ////singlelinkedList.insertatSpecificPosition(80, 7);           
            ////singlelinkedList.insertatMiddle(90);
            ////singlelinkedList.deleteatStart();
            ////singlelinkedList.deleteatEnd();
            ////singlelinkedList.deleteatMid();
            ////singlelinkedList.deleteatPosition(7);
            ////singlelinkedList.reverseList();
            ////singlelinkedList.reverseListRecursive();

            //singlelinkedList.mergeTwoSortedLinkedLists(arr1, arr2);    
            //singlelinkedList.checkLinkedListisPallindrome();
            //singlelinkedList.removeDuplicatesunsortedList();

            //singlelinkedList.AddtwoNumbersinLinkedList(arr1, arr2);

            //singlelinkedList.swapNodesPairwise();
            //singlelinkedList.swapNodesinLLingroupsize(4);
            //singlelinkedList.removeDuplicatessortedList();
            //singlelinkedList.traverseLinkedList();


            //ListNodes.DoublyLinkedList doublyLinkedList = new ListNodes.DoublyLinkedList();
            //doublyLinkedList.create(arr);

            //doublyLinkedList.insertAtStart(1);
            //doublyLinkedList.insertAtEnd(31);
            ////doublyLinkedList.insertAtPosotion(50, 4);
            //doublyLinkedList.insertAtmiddle(55);
            //doublyLinkedList.deleteAtStart();
            //doublyLinkedList.deleteAtEnd();
            //doublyLinkedList.deleteAtPosition(4);
            //doublyLinkedList.deleteAtMiddle();
            //doublyLinkedList.reverseList();
            //doublyLinkedList.traverseDoublyLinkedListFromStart();
            //Console.WriteLine();
            //doublyLinkedList.traverseDoublyLinkedListFromEnd();

            //Binary search tree
            //ListNodes.BinarySearchTree bst = new ListNodes.BinarySearchTree();
            //bst.createBST(arr);

            //bst.DeleteNodeFromBST(8);

            //bst.GetInorderSuccessor(8);

            //bst.FindBSTHeight();

            //bst.breadthfirstsearchLevelOrderTraversal();
            //bst.depthFirstSearchPreOrderTraversal();
            //bst.depthFirstSearchInOrderTraversal();
            //bst.depthFirstSearchPostOrderTraversal();
            //bst.SpiralTraversal();
            //bst.checkBinarytreeisBST();

            //Print nodes having k leaves (Follonw the same logic like to find height of the sub tree).

            //bst.porintNodeshavingKleaves(2);

            //bool areParentesesBalaced = bst.AreParanthesesBalanced("{()()}");
            //Console.WriteLine(areParentesesBalaced ? "Balacned Paranteses" : "Not Balanced Paranteses");

            //int postFixEvalResult = bst.EvaluatePostfix("1 2*3 4*+ 5-");
            //Console.WriteLine("postFixEvalResult "+ postFixEvalResult);

            //InFix to PostFix
            //string inFixtoPostFix = InfixtoPostFix("1+2*3-4*5");
            //Console.WriteLine(inFixtoPostFix);

            //Number of binary search tree we can create with a specific numner
            //bst.NumberBinarySearchCanDrawnwithSpecificNumner(20);

            //Check two binary tress are isomarphic (or) cross isomarphic.

            //bst.LCA();


            //Arrays
            //int[] maxsSubarray = { 4, -3, -2, 2, 3, 1, -2, -3, 4, 2, -6, -3, -1, 3, 1, 2 };
            //maxsumSubarray(maxsSubarray);

            //int[] DuplicateArray = { 1, 2, 2, 3, 3, 3, 4, 4 };
            //RemoveDuplicatesFromArray(DuplicateArray);

            //FibnaciSeries(8);

            //int[] swapArray = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            //SwapzeroOneTwo(swapArray);

            int[,] matrix = new int[4, 4]{
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16}
    };

            int[,] Negativematrix = new int[3, 4]{
            {-3,-2,-1,1},
            {-2,-2,3,4},
            {4,5,7,8}
    };
            //GetUpperBound(0) - Will get Row count
            //GetUpperBound(1) - Will get Col count
            //Printmatrixspiralform(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1));
            //PrintDiagonal(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1));
            //countNegativeValuesinMatrix(Negativematrix, Negativematrix.GetUpperBound(0), Negativematrix.GetUpperBound(1));
            //searchElementinaMatrix(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1), 25);
            PrintAllDiagonal(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1));

        }

        private static void PrintAllDiagonal(int[,] matrix, int lastRow, int lastCol)
        {
          for(int i=0; i <= lastRow; i++)
            {
                int j = i, k = 0;
                while (j >= 0)
                {
                    Console.WriteLine(matrix[j,k]);
                    j--;
                    k++;
                }
            }
          for(int i=1; i<=lastCol; i++)
            {
                int j = lastRow, k = i;
                while (j >=i && k<=lastCol)
                {
                    Console.WriteLine(matrix[j, k]);
                    j--;
                    k++;
                }
            }
        }

        private static void searchElementinaMatrix(int[,] matrix, int lastRow, int lastCol, int searchElement)
        {
            int i = 0, j = lastCol;
            bool searchElementFound = false;

            while (i <= lastRow && j >= 0) {

                if (matrix[i, j] == searchElement)
                {
                    searchElementFound = true;
                    break;
                }
                else if (matrix[i, j] > searchElement)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            if (searchElementFound)
            {
                Console.WriteLine("Search Element Found");
            }
            else
            {
                Console.WriteLine("Search Element not found");
            }
        }

        private static void countNegativeValuesinMatrix(int[,] negativematrix, int lastRow, int lastCol)
        {
            int count = 0;
            for(int i=0; i<= lastRow; i++)
            {
                int j = lastCol;
                while(j >= 0)
                {
                    if(negativematrix[i,j] < 0)
                    {
                        count += j+1;
                        break;
                    }
                    j--;
                }
            }

            Console.WriteLine("Negative values count in this matrix "+ count);
        }

        private static void PrintDiagonal(int[,] matrix, int lastRow, int lastCol)
        {
            //for(int i=0,k=0; i <= lastRow; i++,k++)
            //{
            //    Console.WriteLine(matrix[i,k]);
            //}
            //for(int i=0,k= lastCol; k>=0; i++, k--)
            //{
            //    Console.WriteLine(matrix[i,k]);
            //}
            for (int i = 0, k = 0; i <= lastRow; i++, k++)
            {
                Console.WriteLine(matrix[i, k] + "," + matrix[k, lastRow - i]);
            }
        }

        private static void Printmatrixspiralform(int[,] matrix, int lastRow, int lastCol)
        {
            int i, k = 0, l = 0;
            while (k <= lastRow && l <= lastCol)
            {

                for (i = l; i <= lastCol; i++)
                {
                    Console.WriteLine(matrix[k, i]);
                }
                k++;
                for (i = k; i <= lastRow; i++)
                {
                    Console.WriteLine(matrix[i, lastCol]);
                }
                lastCol--;
                if (k <= lastRow)
                {
                    for (i = lastCol; i >= l; i--)
                    {
                        Console.WriteLine(matrix[lastRow, i]);
                    }
                    lastRow--;
                }
                if (l <= lastCol)
                {
                    for (i = lastRow; i >= k; i--)
                    {
                        Console.WriteLine(matrix[i, l]);
                    }
                    l++;
                }
            }
        }

        private static void SwapzeroOneTwo(int[] swapArray)
        {
            int low = 0, high = swapArray.Length - 1, mid = 0;

            while (mid <= high)
            {
                switch (swapArray[mid])
                {
                    case 0:
                        Swap(swapArray, low, mid);
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        Swap(swapArray, mid, high);
                        high--;
                        break;
                }
            }
        }

        private static void Swap(int[] swapArray, int num1, int numb2)
        {
            int temp = swapArray[num1];
            swapArray[num1] = swapArray[numb2];
            swapArray[numb2] = temp;

        }

        private static void FibnaciSeries(int num)
        {
            int[] arr = new int[num];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }

        private static void RemoveDuplicatesFromArray(int[] duplicateArray)
        {
            int j = 0;
            for (int i = 0; i < duplicateArray.Length - 1; i++)
            {
                if (duplicateArray[i] != duplicateArray[i + 1])
                {
                    duplicateArray[j] = duplicateArray[i];
                    j++;
                }
            }
            duplicateArray[j] = duplicateArray[duplicateArray.Length - 1];

            int arrayLength = duplicateArray.Length - 1;
            //Removed duplicate elements
            while (arrayLength != j)
            {

                duplicateArray = duplicateArray.Where((source, index) => index != j + 1).ToArray();
                arrayLength--;
            }
        }

        private static void maxsumSubarray(int[] arr)
        {
            int maxSoFar = arr[0];
            int maxEndHere = 0;

            int start = 0, end = 0, S = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                maxEndHere = maxEndHere + arr[i];

                if (maxEndHere > maxSoFar)
                {
                    maxSoFar = maxEndHere;
                    start = S;
                    end = i;

                }

                if (maxEndHere < 0)
                {
                    maxEndHere = 0;
                    S = i + 1;
                }
            }
            Console.WriteLine("Max Sum subarray is " + maxSoFar + " and start element position is " + start + " and end element position is" + end);
        }

        private static void MergeSort(int[] arr, int length)
        {
            if (length < 2)
            {
                return;
            }

            int mid = length / 2;

            int[] left = new int[mid];
            int[] right = new int[length - mid];
            for (int i = 0; i < mid - 1; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < length; i++)
            {
                right[i - mid] = arr[i];
            }

            MergeSort(left, left.Length);
            MergeSort(right, right.Length);
            Merge(left, right, arr);

        }

        private static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
            }
            while (j < right.Length)
            {
                arr[j] = right[j];
                j++;
            }
        }

        private static int CircularArraySearch(int[] arr, int length, int searchNumber)
        {
            int start = 0, end = length - 1, mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;

                if (arr[mid] == searchNumber)
                    return mid;

                if (arr[mid] < arr[end])
                {
                    if (searchNumber > arr[mid] && searchNumber <= arr[end])
                        start = mid + 1;
                    else
                        end = mid - 1;
                }

                if (arr[mid] > arr[start])
                {
                    if (searchNumber >= arr[start] && searchNumber < arr[mid])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
            }
            return -1;
        }

        private static int FindrotaionCount(int[] arr, int length)
        {
            int low = 0, high = length - 1;
            int mid = 0;
            while (low <= high)
            {
                if (arr[low] < arr[high])
                    return low;

                mid = (high + low) / 2;
                int next = (mid + 1) % length, prev = (mid + length - 1) % length;
                if (arr[mid] <= next && arr[mid] <= prev)
                    return mid;
                else if (arr[mid] < arr[high])
                    high = mid - 1;
                else if (arr[mid] > arr[low])
                    low = mid + 1;
            }
            return -1;
        }

        private static string InfixtoPostFix(string exp)
        {
            Stack<char> s = new Stack<char>();
            string postFix = "";
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == ' ' || exp[i] == ',')
                    continue;

                else if (IsOperator(exp[i]))
                {
                    if (s.Count != 0 && s.Peek() != '(' && HasHighPrecedence(s.Peek(), exp[i]))
                    {
                        postFix += s.Pop();
                    }
                    s.Push(exp[i]);
                }
                else if (IsOperand(exp[i]))
                {
                    postFix += exp[i];
                }
                else if (exp[i] == '(')
                {
                    s.Push(exp[i]);
                }
                else if (exp[i] == ')')
                {
                    while (s.Count != 0 && s.Peek() != '(')
                    {
                        postFix += s.Pop();
                    }
                    s.Pop();
                }
            }
            while (s.Count != 0)
            {
                postFix += s.Pop();
            }
            return postFix;
        }

        private static bool IsOperand(char C)
        {
            if (C >= '0' && C <= '9') return true;
            if (C >= 'a' && C <= 'z') return true;
            if (C >= 'A' && C <= 'Z') return true;

            return false;
        }

        private static bool HasHighPrecedence(char op1, char op2)
        {
            int op1Weight = GetOperationWeight(op1);
            int op2Weight = GetOperationWeight(op2);

            if (op1Weight == op2Weight)
            {
                if (IsRightAssociative(op1)) return false;
                else return true;
            }
            return op1Weight > op2Weight ? true : false;
        }

        private static bool IsRightAssociative(char op)
        {
            if (op == '$') return true;
            return false;
        }

        private static int GetOperationWeight(char op)
        {
            int weight = -1;
            switch (op)
            {
                case '+':
                case '-':
                    weight = 1;
                    break;
                case '*':
                case '/':
                    weight = 2;
                    break;
                case '$':
                    weight = 3;
                    break;
            }
            return weight;
        }

        private static bool IsOperator(char C)
        {
            if (C == '+' || C == '-' || C == '*' || C == '/' || C == '$') { return true; }
            else
                return false;
        }

        private static string BinarySearch(int[] arr, int arrlength, int SearchElement)
        {
            int start = 0, end = arrlength - 1, mid = 0; ;
            if (arrlength <= 0)
            {
                return "Empty array";
            }
            if (arrlength == 1)
            {
                if (arr[0] == SearchElement)
                {
                    return "Search element " + SearchElement + "Found at position 1";
                }
                else
                {
                    return "Search Element not found";
                }
            }
            else
            {
                while (start <= end)
                {
                    mid = (start + end) / 2;

                    //if mid element is search element return that element
                    if (arr[mid] == SearchElement)
                    {
                        return "Search element " + SearchElement + " Found at position " + mid;
                    }

                    //else check the seaerch element is greater than the mid the take array from mid+1 to end else reverse way.
                    if (arr[mid] < SearchElement)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }

                return "Search Element not found";
            }

        }

        private static int[] BubbleSort(int[] arr, int arrayLength)
        {
            //We need to do n-1 passes.
            for (int p = 0; p < arrayLength - 1; p++)
            {
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    // Compare every element with next element
                    // If first element is greater than second element then swap the elements
                    if (arr[i] > arr[i + 1])
                    {
                        arr = SwapNumbers(arr, i);
                    }
                }
            }
            return arr;
        }

        private static int[] SwapNumbers(int[] arr, int i)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
            return arr;
        }

        private static string stringSearchinaTextBruteForce(string strFirst, string strSecond)
        {
            int secondStrLength = strSecond.Length;
            bool strFound = false;
            int strFoundPosition = 0;
            for (int i = 0; i <= strFirst.Length - secondStrLength + 1; i++)
            {
                int iValue = i;
                for (int j = 0; j < secondStrLength; j++)
                {
                    if (strFirst[i] == strSecond[j])
                    {
                        strFound = true;
                        if (strFoundPosition == 0)
                        {
                            strFoundPosition = i;
                        }
                        i++;
                    }
                    else
                    {
                        strFound = false;
                        strFoundPosition = 0;
                        i = iValue;
                        break;
                    }
                }
            }
            if (!strFound)
            {
                return "string not found";
            }
            else
            {
                return "String Found at postition: " + strFoundPosition;
            }
        }

        private static string stringSearchinaText(string strFirst, string strSecond)
        {
            //Get the lenght of the second string.
            //This will be helpful to find out the substring with this length.

            int secondStrLength = strSecond.Length;
            bool strFound = false;
            int strFoundPosition = 0;
            for (int i = 0; i <= strFirst.Length - secondStrLength; i++)
            {
                if (strFirst.Substring(i, secondStrLength) == strSecond)
                {
                    strFoundPosition = i;
                    strFound = true;
                    break;
                }
            }
            if (!strFound)
            {
                return "string not found";
            }
            else
            {
                return "String Found at postition: " + strFoundPosition;
            }
        }

    }
}
