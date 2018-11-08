using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysProblems
{
    class ContiguousSubarraySum
    {
        public static int Maxsubarraysum(int[] a)
        {
            if(a == null)
            {
                throw new NullReferenceException("Array is null");
            }

            if (a.Length <= 0)
            {
                throw new Exception("Array is empty");
            }

            int maxnow = a[0];
            int tempsum = a[0];
            for(int i= 1; i<a.Length;i++)
            { 
                tempsum = tempsum + a[i];
                if(tempsum < a[i])
                {
                    tempsum = a[i];
                }

                if(tempsum > maxnow)
                {
                    maxnow = tempsum;
                }
            }
            return maxnow;
        }
    }
}
