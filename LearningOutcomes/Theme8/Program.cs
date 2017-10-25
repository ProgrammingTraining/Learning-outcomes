using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme8
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputA, inputB;

            Console.WriteLine("二つの整数を入力してください。");
            Console.Write("整数A：");
            inputA = Console.ReadLine();
            int A = int.Parse(inputA);
         
            Console.Write("整数B：");
            inputB = Console.ReadLine();
            int B = int.Parse(inputB);

            int resultSum = Sum(A,B);
            float resultAve = Ave(A, B, resultSum);

            Console.WriteLine("和は" + resultSum + "で、平均は" + resultAve + "です。");
            Console.ReadLine();
        }

        public static int Sum(int A,int B)
        {
            int resultSum = A + B;
            return resultSum;
        }

        public static float Ave(int A, int B,int resultSum)
        {
            float result = float.Parse(resultSum.ToString());
            float resultAve = result / 2;
            return resultAve;
        }
    }
}
