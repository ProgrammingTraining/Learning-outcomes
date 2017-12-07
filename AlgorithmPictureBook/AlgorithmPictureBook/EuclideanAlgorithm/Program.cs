using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;   //最大公約数を求める二つの自然数
            int r = 1;      //余り
            int c;      //a,b入替処理用変数

            Console.WriteLine("2つの自然数の最大公約数を求めます。");

            Console.Write("a = ");
            string inputA = Console.ReadLine();
            a = int.Parse(inputA);

            Console.Write("b = ");
            string inputB = Console.ReadLine();
            b = int.Parse(inputB);

            //0以下が入力されたとき
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("自然数ではありません。");
                
            }

            Console.Write("{0}と{1}の最大公約数は",a,b);
            if (a < b)//a,b入替
            {
                c = a;
                a = b;
                b = c;
            }
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("{0}です。", a);

            Console.ReadLine();
        }
    }
}
