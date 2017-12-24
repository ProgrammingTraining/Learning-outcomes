using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 6, 5, 1, 2 };
            printData(a);

            int n = 5;
            int i, j, t, h;

            for (h = 1; h <= n; h = 3 * h + 1) ; //比較の間隔hの初期値を決める
            h /= 3;
            while (h >= 1)
            {
                for (i = h; i < n; i++)
                {
                    t = a[i];
                    for (j = i - h; j >= 0; j -= h)
                    {
                        if (a[j] > t)
                        {
                            a[j + h] = a[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    a[j + h] = t;
                    if (j + h != i)
                    {
                        Console.WriteLine("[{0}]の位置に[{1}]を挿入", j + h, i);
                        printData(a);
                    }
                }
                h /= 3;//h個分ずれる
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 配列aの表示
        /// </summary>
        /// <param name="a"></param>
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
