using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enterを入力して、おみくじを引きましょう。");
            Console.ReadLine();
            string[] lot = new string[] { "大吉", "中吉", "吉", "小吉", "末吉", "凶", "大凶" };
            
            int length = lot.Length; //配列の長さ → 7
            int max = length - 1;

            Random cRandom = new System.Random();
            int n = cRandom.Next(max);

            string result = lot[n]; //配列のn番目の要素は？
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
