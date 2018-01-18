using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_1
{
    class Program
    {
        static int factorial(int n)
        {
            if (n > 0)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;//1じゃないと計算できないよ！1のままなら自然数じゃないよ！
            }
        }
        static int Main(string[] args)
        {
            int x;
            Console.Write("自然数を入力せよ：");
            string stx = Console.ReadLine();
            x = int.Parse(stx);

            int result = factorial(x);
            if (result == 1) {
                Console.WriteLine("自然数ではありません。");
            }
            else
            {
                Console.WriteLine("{0}の階乗は{1}です。", x, result);
            }
            Console.ReadLine();

            return 0;
        }
    }
}
