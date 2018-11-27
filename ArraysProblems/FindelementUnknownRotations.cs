using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysProblems
{
    class FindelementUnknownRotations
    {
        public static int PivotBinarySearch(int[] arr, int len, int elementval)
        {
            int pivot = FindPivot(arr, 0, len - 1);
            if (pivot == -1)
                return BinarySearch(arr, 0, len - 1, elementval);
            if (arr[pivot] == elementval)
                return pivot;
            if (arr[0] <= elementval)
                return BinarySearch(arr, 0, pivot - 1, elementval);
            else

                return BinarySearch(arr, pivot + 1, len - 1, elementval);
        }

        private static int FindPivot(int[] arr, int low, int high)
        {
            // base cases 
            if (high < low)
                return -1;

            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (mid < high && arr[mid] > arr[mid + 1])
                return mid;

            if (mid > low && arr[mid] < arr[mid - 1])
                return (mid - 1);

            if (arr[low] >= arr[mid])
                return FindPivot(arr, low, mid - 1);

            return FindPivot(arr, mid + 1, high);
        }

        /* Standard Binary Search function */
        private static int BinarySearch(int[] arr, int low,
                                int high, int elementval)
        {
            if (high < low)
            {
                Console.WriteLine("Element not found in the sorted and rotated array");
                return -1;
            }


            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (elementval == arr[mid])
                return mid;
            if (elementval > arr[mid])
                return BinarySearch(arr, (mid + 1), high, elementval);

            return BinarySearch(arr, low, (mid - 1), elementval);
        }
    }
}
