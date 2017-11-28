using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxValue = 50;//最大値
            int[] resultArray = new int[MaxValue + 1];
            int i,j;

            for (i = 2; i <= MaxValue; i++)//配列の初期化。すべてに0を格納
            {
                resultArray[i] = 0;
            }

            for (i = 2; i <= 10; i++)//2~10が素数かチェック。
            {
                if (resultArray[i] == 0)
                {
                    for (j = 2; j <= MaxValue; j++)
                    {
                        int result = i * j;
                        if (result <= MaxValue)//iの倍数が10以内にあればresultArray[] = 1
                        {
                            resultArray[result] = 1;
                        }
                    }
                }
            }

            for  (i = 2; i <= MaxValue; i++)
            {
                if (resultArray[i] == 0)//もし配列の中身が0なら表示
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
