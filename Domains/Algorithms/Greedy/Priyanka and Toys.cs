using System;
using System.Linq;

namespace PriyankAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToys = Int32.Parse(Console.ReadLine());
            int[] toys = Console.ReadLine().Split().Select(n => Int32.Parse(n)).ToArray();

            Array.Sort(toys);

            int costOfLastToy = Int32.MinValue;
            int toysToBuy = 0;

            for(int i =0; i<numToys; i++)
            {
                int priceDifference = toys[i] - costOfLastToy;
                if (priceDifference >= 0 && priceDifference <= 4)
                {
                    continue;
                }
                else
                {
                    toysToBuy++;
                    costOfLastToy = toys[i];
                }
            }

            Console.WriteLine(toysToBuy);
        }
    }
}
