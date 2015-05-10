using System;

namespace bdaygift
{
    class bdaygift
    {
        static void Main(string[] args)
        {
            int balls = Int32.Parse(Console.ReadLine());
            
            double sum = 0;
            while(balls-- > 0)
            {
                double ballValue = Int32.Parse(Console.ReadLine());
                sum += ballValue / 2;
            }

            Console.WriteLine(string.Format("{0:0.0}", sum));
        }
    }
}
