using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme1
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の宣言
            string a, b; //入力値A、入力値B

            Console.WriteLine("2つの整数を入力してください。");

            Console.Write("数値A：");
            a = Console.ReadLine();
            int inputA = int.Parse(a);

            Console.Write("数値B：");
            b = Console.ReadLine();
            int inputB = int.Parse(b);

            int sum = inputA + inputB;
            int integration = inputA * inputB;
            Console.WriteLine("それらの和は{0}で積は{1}です。", sum, integration);
            Console.ReadLine();
        }
    }
}
