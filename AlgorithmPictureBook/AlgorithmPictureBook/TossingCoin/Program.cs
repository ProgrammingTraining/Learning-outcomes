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
            
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("表は１、裏は２、終了は他の値を入力してください。");
                string[] direction = new string[] { "表", "裏","-"};
                int max = direction.Length;//2-1=1 [0,1] 
                Console.WriteLine("max:" + max);

                Random cRandom = new System.Random();//coin
                coinNumber = cRandom.Next(max);
                Console.WriteLine("coinNumber:" + coinNumber);

                coin = direction[coinNumber];
                Console.WriteLine("coin:" + coin);

                Console.Write("コインを投げました。表？裏？：");//入力
                inputYou = Console.ReadLine();
                youNumber = int.Parse(inputYou);
                youNumber -= 1;
                Console.WriteLine("表は0、裏は1:" + youNumber);

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
                    you = "dame";
                }

                again = Again(again);
            }

            Console.ReadLine();
        }
        public static bool Again(bool again)
        {
            string choice = string.Empty;
            Console.Write("もう一度しますか（1・・・はい、2・・・いいえ）：");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                again = true;
            }
            else if (choice == "2")
            {
                again = false;
            }
            else
            {
                Console.WriteLine("もう一度入力してください。");
            }
            return again;
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
