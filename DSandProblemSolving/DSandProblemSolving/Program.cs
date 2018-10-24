using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving
{
    class Job : IComparable
    {
        public int start;
        public int end;
        public int profit;
        public Job(int start, int end, int profit)
        {
            this.start = start;
            this.end = end;
            this.profit = profit;
        }

        public int CompareTo(object obj)
        {
            if (obj is Job)
            {
                return this.end.CompareTo((obj as Job).end);  // compare user names
            }
            throw new ArgumentException("Object is not a User");
        }
    }
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

            //Minimunm Jumps to reach end of the array.
            //int[] array  = { 2,1,3,2,3,4,5,1,2,8 };
            //int[] JumpPathArray = new int[array.Length]; // to store where it jumps from.
            //int[] JumpArray = new int[array.Length]; // to store minimum number requries for each index.


            //String str1 = "ABCDGHLQR";
            //String str2 = "AEDPHR";

            //lcsDynamic(str1.ToCharArray(), str2.ToCharArray());

            //int[] array = { 2, 3, 7, 8, 10 };
            //subsetSumArray(array, 10); // need subset where sum is 11

            //int[] array = { 4, 2, 3, 5, 3 };
            //MatrixMultiplicationCost(array);

            //int[] array = { 3, 2, 4 };
            //coinChangeCombination(array, 6); // minimumn coins needed to make the needed total here 6.

            //Another way two dimensioianl
            //int[] coinsArray = { 1, 5, 6, 8 };
            //coinChangeCombination2dway(coinsArray, 11);

            //String str1 = "azced";
            //String str2 = "abcdef";           
            //dynamicEditDistance(str1.ToCharArray(), str2.ToCharArray());

            ////WeightedJobScheduledProblem
            //Job[] jobs = new Job[6];
            //jobs[0] = new Job(1, 3, 5);
            //jobs[1] = new Job(2, 5, 6);
            //jobs[2] = new Job(4, 6, 5);
            //jobs[3] = new Job(6, 7, 4);
            //jobs[4] = new Job(7, 9, 2);
            //jobs[5] = new Job(5, 8, 11);

            //maximumProfits(jobs);

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
            PrintDiagonal(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1));
            //countNegativeValuesinMatrix(Negativematrix, Negativematrix.GetUpperBound(0), Negativematrix.GetUpperBound(1));
            //searchElementinaMatrix(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1), 25);
            //PrintAllDiagonal(matrix, matrix.GetUpperBound(0), matrix.GetUpperBound(1));

        }

        private static void maximumProfits(Job[] jobs)
        {
            int[] temp = new int[jobs.Length];
            Array.Sort(jobs); // Since we have implemented Icomparable to job class and implemented compareto function

            temp[0] = jobs[0].profit;
            for (int i = 1; i < jobs.Length; i++)
            {
                temp[i] = Math.Max(jobs[i].profit, temp[i - 1]);
                for (int j = i - 1; j >= 0; j--)
                {
                    if (jobs[j].end <= jobs[i].start)
                    {
                        temp[i] = Math.Max(temp[i], jobs[i].profit + temp[j]);
                        break;
                    }
                }
            }           
            Console.WriteLine(temp.Max());
        }

        private static void dynamicEditDistance(char[] string1, char[] string2)
        {
            int[,] temp = new int[string1.Length + 1, string2.Length + 1];

            for (int i = 0; i < string1.Length; i++)
            {
                temp[i, 0] = i;
            }
            for (int i = 0; i < string2.Length; i++)
            {
                temp[0, i] = i;
            }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                    {
                        temp[i, j] = temp[i - 1, j - 1];
                    }
                    else
                    {
                        temp[i, j] = min(temp[i - 1, j], temp[i, j - 1], temp[i - 1, j - 1]) + 1;
                    }
                }
            }
            printActualEdits(temp, string1, string2);
            Console.WriteLine(temp[string1.Length, string2.Length]);
        }
        public static void printActualEdits(int[,] T, char[] str1, char[] str2)
        {
            int i = T.Length - 1;
            int j = T.Length - 1;
            while (true)
            {
                if (i == 0 || j == 0)
                {
                    break;
                }
                if (str1[i - 1] == str2[j - 1])
                {
                    i = i - 1;
                    j = j - 1;
                }
                else if (T[i, j] == T[i - 1, j - 1] + 1)
                {
                    Console.WriteLine("Edit " + str2[j - 1] + " in string2 to " + str1[i - 1] + " in string1");
                    i = i - 1;
                    j = j - 1;
                }
                else if (T[i, j] == T[i - 1, j] + 1)
                {
                    Console.WriteLine("Delete in string1 " + str1[i - 1]);
                    i = i - 1;
                }
                else if (T[i, j] == T[i, j - 1] + 1)
                {
                    Console.WriteLine("Delete in string2 " + str2[j - 1]);
                    j = j - 1;
                }
            }
        }
        private static int min(int a, int b, int c)
        {
            int l = Math.Min(a, b);
            return Math.Min(l, c);
        }

        private static void coinChangeCombination2dway(int[] array, int total)
        {
            int[,] temp = new int[array.Length + 1, total + 1];
            for (int i = 0; i <= array.Length; i++)
            {
                temp[i, 0] = 0;
            }

            for (int i = 1; i <= total; i++)
            {
                temp[0, i] = i;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    if (j >= array[i - 1])
                    {
                        temp[i, j] = Math.Min(temp[i - 1, j], temp[i, j - array[i - 1]] + 1);
                    }
                    else
                    {
                        temp[i, j] = temp[i - 1, j];
                    }
                }
            }
            Console.WriteLine(temp[array.Length, total]);

            int arrayLength = array.Length;

            do
            {
                if (temp[arrayLength, total] != 0 && temp[arrayLength, total] == temp[arrayLength - 1, total])
                {
                    arrayLength = arrayLength - 1;
                }
                else
                {
                    Console.WriteLine(array[arrayLength - 1]);
                    total = total - array[arrayLength - 1];
                    arrayLength = arrayLength - 1;
                }
            }
            while (total != 0);
        }

        private static void coinChangeCombination(int[] array, int total)
        {
            //Make two arrays with total +1 length
            int[] temp1 = new int[total + 1];
            int[] temp2 = new int[total + 1];

            for (int i = 0; i <= total; i++)
            {
                temp1[i] = int.MaxValue - 1;
                temp2[i] = -1;
            }
            temp1[0] = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    if (j >= array[i])
                    {
                        if (temp1[j] > temp1[j - array[i]] + 1)
                        {
                            temp2[j] = i;
                            temp1[j] = temp1[j - array[i]] + 1;
                        }
                    }
                }
            }
            Console.WriteLine("Result :" + temp1[temp1.Length - 1]);
            int maxCoins = temp1[temp1.Length - 1];
            while (maxCoins != 0 && maxCoins != int.MaxValue - 1)
            {
                Console.WriteLine(array[maxCoins]);
                maxCoins = temp1[maxCoins];
            }
        }
        private static void minimunJumps(int[] array, int[] jumpArray, int[] jumpPathArray)
        {
            jumpArray[0] = 0;
            for (int i = 1; i < array.Length; i++)
            {
                jumpArray[i] = int.MaxValue - 1;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] + j >= i)
                    {
                        if (jumpArray[j] + 1 < jumpArray[i])
                        {
                            jumpPathArray[i] = j;
                            jumpArray[i] = jumpArray[j] + 1;
                        }
                    }
                }
            }
            Console.WriteLine(jumpArray[jumpArray.Length - 1]);

            int minimumJump = jumpPathArray.Length - 1;
            while (minimumJump != 0)
            {
                Console.WriteLine(minimumJump);
                minimumJump = jumpPathArray[minimumJump];
            }
            Console.WriteLine("0");
        }
        private static void MatrixMultiplicationCost(int[] arr)
        {
            int[,] temp = new int[arr.Length, arr.Length];
            int q = 0;
            for (int l = 2; l < arr.Length; l++)
            {
                for (int i = 0; i < arr.Length - l; i++)
                {
                    int j = i + l;
                    temp[i, j] = 1000000;
                    for (int k = i + 1; k < j; k++)
                    {
                        q = temp[i, k] + temp[k, j] + arr[i] * arr[k] * arr[j];
                        if (q < temp[i, j])
                        {
                            temp[i, j] = q;
                        }
                    }
                }
            }
            Console.WriteLine(temp[0, arr.Length - 1]);
        }

        private static void subsetSumArray(int[] array, int sunValue)
        {
            bool[,] temp = new bool[array.Length + 1, sunValue + 1];
            for (int i = 0; i < array.Length + 1; i++)
            {
                temp[i, 0] = true;
            }

            for (int j = 1; j <= sunValue; j++)
            {
                temp[0, j] = false;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 1; j <= sunValue; j++)
                {
                    if (j < array[i - 1])
                    {
                        temp[i, j] = temp[i - 1, j];
                    }
                    else
                    {
                        temp[i, j] = temp[i - 1, j] || temp[i - 1, j - array[i - 1]];
                    }
                }
            }
            //Write the sub set element where sum of those values is the expected sum value
            int arrayLength = array.Length;
            do
            {
                if (temp[arrayLength, sunValue])
                {
                    arrayLength = arrayLength - 1;
                }
                else
                {
                    Console.WriteLine(array[arrayLength]);
                    sunValue = sunValue - array[arrayLength];
                    arrayLength = arrayLength - 1;


                }

            }
            while (sunValue != 0);
            Console.WriteLine(temp[array.Length, sunValue]);
        }

        private static void lcsDynamic(char[] str1, char[] str2)
        {
            int[,] temp = new int[str1.Length + 1, str2.Length + 1];
            int max = 0;
            for (int i = 1; i < str1.Length + 1; i++)
            {
                for (int j = 1; j < str2.Length + 1; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        temp[i, j] = temp[i - 1, j - 1] + 1;
                        Console.WriteLine(str1[i - 1]);
                    }
                    else
                    {
                        temp[i, j] = Math.Max(temp[i, j - 1], temp[i - 1, j]);
                    }
                    if (temp[i, j] > max)
                    {
                        max = temp[i, j];
                    }
                }
            }
            Console.WriteLine(max);
        }



        private static void PrintAllDiagonal(int[,] matrix, int lastRow, int lastCol)
        {
            for (int i = 0; i <= lastRow; i++)
            {
                int j = i, k = 0;
                while (j >= 0)
                {
                    Console.WriteLine(matrix[j, k]);
                    j--;
                    k++;
                }
            }
            for (int i = 1; i <= lastCol; i++)
            {
                int j = lastRow, k = i;
                while (j >= i && k <= lastCol)
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

            while (i <= lastRow && j >= 0)
            {

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
            for (int i = 0; i <= lastRow; i++)
            {
                int j = lastCol;
                while (j >= 0)
                {
                    if (negativematrix[i, j] < 0)
                    {
                        count += j + 1;
                        break;
                    }
                    j--;
                }
            }

            Console.WriteLine("Negative values count in this matrix " + count);
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
