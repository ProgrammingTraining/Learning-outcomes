using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 6, 5, 1, 2 };
            printData(a);


            int n = 5;
            int i, j, t;
            for (i = 1; i < n; i++)
            {
                t = a[i];
                for (j = i-1; j >= 0; j--)
                {
                    if (a[j] > t)
                    {
                        a[j+1] = a[j];
                    }
                    else
                    {
                        break;
                    }
                }
                a[j + 1] = t;
                if (j+1 != i)
                {

                    Console.WriteLine("[{0}]の位置に[{1}]を挿入", j+1, i);
                    printData(a);
                }
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
