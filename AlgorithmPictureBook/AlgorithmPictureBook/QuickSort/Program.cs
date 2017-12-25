using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 6, 5, 2, 1, 3, 9, 7};
            printData(a);
            qs(a,0,8);

            Console.ReadLine();
        }
        /// <summary>
        /// クイックソートを行う関数
        /// </summary>
        static void qs(int[] a, int first, int last)
        {
            int i, j, x;
            i = first;
            j = last;
            x = (a[i] + a[j]) / 2;//基準値
            
            while(true)
            {
                while(a[i] < x)
                {
                    i++;
                }
                while(a[j] > x)
                {
                    j--;
                }
                if(i >= j)
                {
                    break;
                }
                swap(i, j, a);
                Console.WriteLine("範囲：{0}-{1}　基準値：{2}　[{3}]と[{4}]を入れ替え", first, last, x, i, j);
                printData(a);
                i++;
                j--;
            }
            if (first < i-1)//基準値よりも小さいグループの入替
            {
                qs(a, first, i-1);
            }
            if (j+1 < last)//基準値よりも大きいグループの入替
            {
                qs(a, j+1, last);
            }
        }

        /// <summary>
        /// 入替
        /// </summary>
        static void swap(int i, int j, int[] a)
        {
            int x;
            x = a[j];
            a[j] = a[i];
            a[i] = x;
        }
        /// <summary>
        /// 配列aの表示
        /// </summary>
        static void printData(int[] a)
        {
            foreach (int k in a)
            {
                System.Console.Write("{0} ", k);
            }
            Console.WriteLine();
        }
    }
}
