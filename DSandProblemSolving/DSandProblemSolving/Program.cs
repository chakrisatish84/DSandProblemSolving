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
            string strFirst = "abcbcfgm";
            string strSecond = "bcfgm";

            //string sResult = stringSearchinaText(strFirst, strSecond);
            //BruteForce
            string sResult = stringSearchinaTextBruteForce(strFirst, strSecond);
            Console.WriteLine(sResult);
            #endregion

            //Bubble Sort
            #region BubbleSort
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };
            int[] bubbleSortArray = BubbleSort(arr, arr.Length);
             Console.WriteLine(string.Join(",", bubbleSortArray));
            #endregion

        }

        private static int[] BubbleSort(int[] arr, int arrayLength)
        {
            for (int p = 0; p < arrayLength - 1; p++)
            {
                for (int i = 0; i < arrayLength - 1; i++)
                {
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
