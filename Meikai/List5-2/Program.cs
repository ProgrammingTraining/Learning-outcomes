using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_2
{
    class Program
    {
        static int gcd(int x, int y)
        {
            if(y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("二つの整数の最大公約数を求めます。");

            Console.Write("整数を入力せよ：");
            string stx = Console.ReadLine();
            x = int.Parse(stx);

            Console.Write("整数を入力せよ：");
            string sty = Console.ReadLine();
            y = int.Parse(sty);

            Console.WriteLine("最大公約数は{0}です。",gcd(x,y));
            Console.ReadLine();
        }
    }
}
