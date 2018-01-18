using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_3
{
    class Program
    {
        static void recur(int n)
        {
            if(n > 0)
            {
                recur(n - 1);
                Console.WriteLine("n:{0}", n);
                recur(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int x;

            Console.Write("整数を入力せよ:");
            string stx = Console.ReadLine();
            x = int.Parse(stx);

            recur(x);
            Console.ReadLine();
        }
    }
}
