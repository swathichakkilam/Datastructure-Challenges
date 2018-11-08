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
        }
    }
}
