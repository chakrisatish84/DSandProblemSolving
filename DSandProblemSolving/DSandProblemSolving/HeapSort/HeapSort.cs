using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.HeapSort
{
    class HeapSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }
            Console.WriteLine("Max Heap "+ string.Join(",", arr));
            for (int i = n - 1; i > 0; i--)
            {
                Swap(arr, 0, i);
                heapify(arr, i, 0);
            }
            Console.WriteLine("Sorted Array " +string.Join(",", arr));
        }

        private void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);
                heapify(arr, n, largest);
            }

        }

        private void Swap(int[] arr, int i, int largest)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
        }
    }
}
