using System;

namespace ArraysProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] {-2, -3, 4, -1, 3, 10, 22, 7};

            var maxSum = ContiguousSubarraySum.Maxsubarraysum(arr);

            Console.WriteLine($"Max sum {maxSum}");
            Console.ReadLine();


            int[] arr1 = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int n = arr1.Length;
            int key = 42;
            Console.Write("Index of the element is : "
                        + FindelementUnknownRotations.PivotBinarySearch(arr1, n, key));
            Console.ReadLine();

        }
    }
}
