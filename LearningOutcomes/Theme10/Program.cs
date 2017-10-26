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
            string choice = "initialValue";

            Console.Write("Enterを入力して、おみくじを引きましょう。");
            string firstChoice = Console.ReadLine();
            choice = Fortune(choice, firstChoice);

            if (choice == "1")
            {
                Fortune(choice, firstChoice);
            }
        }
        public static string Fortune( string choice, string firstChoice)
        {
            if (firstChoice == "" || choice == "1")
            {
                string[] lot = new string[] { "大吉", "中吉", "吉", "小吉", "末吉", "凶", "大凶" };

                int max = lot.Length - 1; //配列の長さ → 7-1=6

                Random cRandom = new System.Random();
                int n = cRandom.Next(max);

                string result = lot[n]; //配列のn番目の要素は？
                Console.WriteLine("運勢：" + result);

                Console.Write("もう一度しますか（1・・・はい、2・・・いいえ）：");
                choice = Console.ReadLine();
            }
            return choice;
        }
    }
}
