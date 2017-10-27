using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme10
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;

            Console.Write("Enterを入力して、おみくじを引きましょう。");
            Console.ReadLine();
            Fortune();

            bool again = true;
            while (again == true)
            {
                Console.Write("もう一度しますか（1・・・はい、2・・・いいえ）：");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Fortune();
                }
                else if (choice == "2")
                {
                    again = false;
                }
                else
                {
                    Console.WriteLine("もう一度入力してください。");
                }
            }
        }
        public static void Fortune()
        {
            string[] lot = new string[] { "大吉", "中吉", "吉", "小吉", "末吉", "凶", "大凶" };

            int max = lot.Length - 1; //配列の長さ → 7-1=6

            Random cRandom = new System.Random();
            int n = cRandom.Next(max);

            string result = lot[n]; //配列のn番目の要素は？
            Console.WriteLine("運勢：" + result);
        }
    }
}
