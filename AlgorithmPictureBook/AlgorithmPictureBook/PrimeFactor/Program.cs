using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static int maxValue=100;
        static void Main(string[] args)
        {
            Console.Write("素因数分解する数を入力してください。:");
            string inputNumber = Console.ReadLine();
            maxValue = int.Parse(inputNumber);

            int[] primeList = PrimeNumber(maxValue);//素数の計算
            int i = 0;
            while (maxValue != 1)//1になったら終わり
            {
                while (maxValue % primeList[i] == 0)
                {
                    Console.Write("{0} ", primeList[i]);
                    maxValue = maxValue / primeList[i];
                }
                
                i++;
            }
            Console.ReadLine();
        }

        //素数の計算
        static int[] PrimeNumber(int maxValue)
        {
            int n = 0;
            int[] resultArray = new int[maxValue + 1];
            int[] primeList = new int[maxValue + 1];//素数のリスト
            int i, j;

            for (i = 2; i <= maxValue; i++)//配列の初期化。すべてに0を格納
            {
                resultArray[i] = 0;
            }

            for (i = 2; i <= maxValue; i++)//2~MaxValueが素数かチェック。
            {
                if (resultArray[i] == 0)
                {
                    for (j = 2; j <= maxValue; j++)
                    {
                        int result = i * j;
                        if (result <= maxValue)//iの倍数がMaxValue以内にあればresultArray[] = 1
                        {
                            resultArray[result] = 1;
                        }
                    }
                }
            }

            for (i = 2; i <= maxValue; i++)
            {
                if (resultArray[i] == 0)//もし配列の中身が0ならprimeListに格納
                {
                    primeList[n] = i;
                    n++;
                }
            }
            return primeList;
        }
    }
}
