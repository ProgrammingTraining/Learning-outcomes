using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 13, 44, 52, 55, 67, 88, 93 };//昇順になってるのが条件
            int n = 9;//要素数
            int i, x, lo, hi, m;

            printData(a);
            Console.Write("探したいデータを入力してください：");
            string inputNumber = Console.ReadLine();
            x = int.Parse(inputNumber);

            lo = 0;　//探索最小値
            hi = n - 1;　//探索最大値
            m = (lo + hi) / 2; //半分の位置

            while ( lo <= hi)
            {
                if(a[m] == x)
                {
                    break;
                }
                else if (a[m] < x) //入力値が半分の値より大きい場合は探索最小値を「半分の値の次の数」にする
                {
                    lo = m + 1;
                }
                else　　　　　　　//入力値が半分の値より小さい場合は探索最小値を「半分の値の前の数」にする
                {
                    hi = m - 1;
                }
                m = (lo + hi) / 2; //半分の半分に探索範囲を狭める
            }

            if (a[m] == x)
            {
                Console.WriteLine("{0}はa[{1}]にあります。", x, m);
            }
            else
            {
                Console.WriteLine("{0}はありません。",x);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// 配列aの表示
        /// </summary>
        static void printData(int[] a)
        {
            Console.Write("a[] = {");
            foreach (int k in a)
            {
                System.Console.Write("{0} ", k);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
