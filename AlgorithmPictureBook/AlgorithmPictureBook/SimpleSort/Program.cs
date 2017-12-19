using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 3, 5 };
            printData(a);


            int n = 4;
            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = j + 1; i <= n - 1; i++)
                {
                    if (a[j] < a[i])
                    {
                        swap(i,j,a);

                        Console.WriteLine("[{0}]と[{1}]を入れ替え", i, j);
                        printData(a);
                    }
                }
            }
            Console.ReadLine();
        }
        static void swap(int i,int j,int[]a)
        {
            int x;
            x = a[j];
            a[j] = a[i];
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
