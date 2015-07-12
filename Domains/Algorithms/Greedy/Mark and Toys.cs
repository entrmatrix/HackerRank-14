using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toysAndMoney = Console.ReadLine().Split();
            int numToys = Int32.Parse(toysAndMoney[0]);
            int money = Int32.Parse(toysAndMoney[1]);

            int[] toys = Console.ReadLine().Split().Select(n => Int32.Parse(n)).ToArray();

            Array.Sort(toys);

            int toysToBuy = -1;
            for(int i = 0; i<numToys && money > 0; i++)
            {
                toysToBuy++;
                money -= toys[i];  
            }

            Console.WriteLine(toysToBuy);
        }
    }
}