using System;
using System.Diagnostics;
using System.Linq;

namespace find_median
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElements = Int32.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(n => Int32.Parse(n)).ToArray();
            Debug.Assert(numElements == numbers.Count());

            Array.Sort(numbers);
            //problem guarantees numElements is odd
            Console.WriteLine(numbers[numElements / 2]);
        }
    }
}