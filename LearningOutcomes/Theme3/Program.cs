using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme3
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の宣言
            string a, b, c; //入力値A、入力値B
            int inputA, inputB, inputC, compare, result;

            Console.WriteLine("3つの整数を入力してください。");

            Console.Write("数値A：");
            a = Console.ReadLine();
            inputA = int.Parse(a);

            Console.Write("数値B：");
            b = Console.ReadLine();
            inputB = int.Parse(b);

            Console.Write("数値C：");
            c = Console.ReadLine();
            inputC = int.Parse(c);

            compare = Math.Min(inputA, inputB);
            result = Math.Min(inputC, compare);

            Console.WriteLine("最小値は" + result + "です。");

            Console.ReadLine();
        }
    }
}
