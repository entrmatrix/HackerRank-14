using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace maximum_subarray
{
    class max_subarray
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());

            while (testCases-- > 0)
            {
                int numElements = Int32.Parse(Console.ReadLine());
                int[] array = Console.ReadLine().Split().Select(n => Int32.Parse(n)).ToArray();
                Debug.Assert(array.Count() == numElements);

                Console.WriteLine(MaxContiguousSubarray(array) + " " + MaxNonContiguousSubarray(array));
            }
        }

        static int MaxContiguousSubarray(int[] array)
        {
            Debug.Assert(array.Count() > 0);

            int bestSumSoFar, maxEndingHere;
            bestSumSoFar = maxEndingHere = array[0];

            for (int i = 1; i < array.Count(); i++)
            {
                maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);
                bestSumSoFar = Math.Max(maxEndingHere, bestSumSoFar);
            }

            return bestSumSoFar;
        }

        static int MaxNonContiguousSubarray(int[] array)
        {
            Array.Sort(array);

            //add the highest value element, even if all elements are negative we need to return a number
            int sum = array[array.Count() - 1];

            //add all other positve numbers in the array
            for (int i = array.Count() - 2; i >= 0 && array[i] > 0; i--)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
