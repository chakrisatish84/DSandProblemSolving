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
            #endregion

            // singleLinkedList
            //int[] arr = { 2, 5, 7, 11, 12, 15, 20, 30, 34, 36, 30,40 };
            int[] arr = { 6, 5, 3, 1, 8, 7, 10, 2, 4,12 };
            //int[] arr1 = { 10,50,70,90,100 };
            //int[] arr2 = { 30,40,60,80 };
            //Add two lists
            int[] arr1 = {1,2,3,4,5 };
            int[] arr2 = { 9, 6, 3 };
            int[] listPallindrome = { 1, 2, 3, 3, 2, 1 };
            int[] arraywithDuplicates = { 1, 2, 2, 3, 3, 3, 4 };
            ListNodes.SingleLinkedList singlelinkedList = new ListNodes.SingleLinkedList();
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
            ListNodes.BinarySearchTree bst = new ListNodes.BinarySearchTree();
            bst.createBST(arr);

            bst.DeleteNodeFromBST(8);

            bst.breadthfirstsearchLevelOrderTraversal();
            //bst.depthFirstSearchPreOrderTraversal();
            //bst.depthFirstSearchInOrderTraversal();
            //bst.depthFirstSearchPostOrderTraversal();
            //bst.checkBinarytreeisBST();
            
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
                        end = mid -1;
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
