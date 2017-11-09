using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossingCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputYou,you,coin;
            int youNumber, coinNumber;

            Console.WriteLine("表は１、裏は２、終了は他の値を入力してください。");
            string[] direction = new string[] { "表", "裏" };
            int max = direction.Length; 

            Random cRandom = new System.Random();//coin
            coinNumber = cRandom.Next(max);
            coin = direction[coinNumber];

            Console.Write("コインを投げました。表？裏？：");//入力
            inputYou = Console.ReadLine();
            youNumber = int.Parse(inputYou);
            youNumber -= 1;

            if (inputYou == "1")
            {
                you = "表";
                Fortune(you, coin, youNumber, coinNumber);
            }
            else if (inputYou == "2")
            {
                you = "裏";
                Fortune(you, coin, youNumber, coinNumber);
            }
            else
            {
                Console.WriteLine("終了");
            }
            Console.ReadLine();
        }
        public static void Fortune(string you,string coin,int youNumber, int coinNumber)
        {
            Console.WriteLine("あなた：" + you + "　コイン：" + coin);

            if (youNumber == coinNumber)
            {
                Console.WriteLine("あたり！");
            }
            else
            {
                Console.WriteLine("はずれ～");
            }
        }
    }
}
