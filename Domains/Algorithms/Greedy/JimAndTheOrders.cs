using System;

namespace JimAndTheOrders
{
    class JimAndTheOrders
    {
        static void Main(string[] args)
        {
            int numOrders = Int32.Parse(Console.ReadLine());
            Order[] orders = new Order[numOrders];

            for(int i = 0; i<numOrders; i++)
            {
                string orderInfo = Console.ReadLine();
                int start = Int32.Parse(orderInfo.Split()[0]);
                int process = Int32.Parse(orderInfo.Split()[1]);

                orders[i] = new Order(i+1, start, process);
            }

            Array.Sort(orders);

            string orderOutput = "";
            foreach(Order o in orders)
            {
                orderOutput += o.Number + " ";
            }
            orderOutput = orderOutput.Trim();

            Console.WriteLine(orderOutput);
        }

        class Order : IComparable<Order>
        {
            private int _number, _startTime, _procTime;

            public int Number
            {
                get { return _number; }
            }

            public Order(int num, int startT, int procT)
            {
                _number = num;
                _startTime = startT;
                _procTime = procT;
            }


            public int CompareTo(Order other)
            {
                if ((this._startTime + this._procTime) == (other._startTime + other._procTime))
                {
                    return this._number - other._number;
                }
                else
                {
                    return (this._startTime + this._procTime) - (other._startTime + other._procTime);
                }
            }
        }
    }
}
