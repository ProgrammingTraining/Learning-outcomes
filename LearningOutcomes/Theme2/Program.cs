using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme2
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の宣言
            string a; //入力値
            
            Console.Write("整数を入力してください：");
            a = Console.ReadLine();
            int inputA = int.Parse(a);

            int Sign = System.Math.Sign(inputA);
            
            if (Sign == 1)
            {
                Console.WriteLine("その数は正です。");
            }
            else if (Sign == -1)
            {
                Console.WriteLine("その数は負です。");
            }
            else
            {
                Console.WriteLine("その数は0です。");
            }
            
            Console.ReadLine();
        }
    }
}
