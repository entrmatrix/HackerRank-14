using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClosestNumbers
{
    class ClosestNumbers
    {
        static void Main(string[] args)
        {
            int numElements = Int32.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(n => Int32.Parse(n)).ToArray();
            Debug.Assert(numElements == numbers.Count() && numElements > 1);

            Array.Sort(numbers);

            List<int> leastDifferencePairs = new List<int>();
            leastDifferencePairs.Add(numbers[1]);
            leastDifferencePairs.Add(numbers[0]);
            int leastDifference = numbers[1] - numbers[0];
            
            for(int i = 2; i<numbers.Count(); i++)
            {
                int difference = numbers[i] - numbers[i - 1];
                if (difference > leastDifference)
                {
                    continue;
                }
                else
                {
                    if (difference < leastDifference)
                    {
                        leastDifference = difference;
                        leastDifferencePairs.Clear();
                    }

                    leastDifferencePairs.Add(numbers[i-1]);
                    leastDifferencePairs.Add(numbers[i]);
                }
            }

            string outputPairs = "";
            foreach(int n in leastDifferencePairs)
            {
                outputPairs += n + " ";
            }
            outputPairs = outputPairs.Trim();

            Console.WriteLine(outputPairs);
        }
    }
}
