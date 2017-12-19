using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 1, 3 };
            printData(a);


            int n = 4;
            for (int j = n-1; j >= 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        swap(i, a);

                        Console.WriteLine("[{0}]と[{1}]を入れ替え", i, i+1);
                        printData(a);
                    }
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 入替
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="a"></param>
        static void swap(int i, int[] a)
        {
            int x;
            x = a[i+1];
            a[i+1] = a[i];
            a[i] = x;
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
