using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List6_16
{
    class Program
    {
        static void fsort(int[] a)
        {
            int i;
            int max = 100;
            int[] f = new int[max + 1];     //累積度数配列
            int[] b = new int[a.Length];//作業用目的配列

            for (i = 0; i <= max; i++)//Step0:
            {
                f[i] = 0;
            }
            for (i = 0; i < a.Length; i++)//Step1:度数分布表の作成
            {
                f[a[i]]++;
            }
            Console.WriteLine("Step1");
            for (int n = 0; n < f.Length; n++)
            {
                Console.WriteLine("f[{0}]:{1}", n, f[n]);
            }
            for (i = 1; i <= max; i++)//Step2:累積度数分布表の作成
            {
                f[i] += f[i - 1];
            }
            Console.WriteLine("Step2");
            for (int n = 0; n < f.Length; n++)
            {
                Console.WriteLine("f[{0}]:{1}", n, f[n]);
            }
            for (i = a.Length - 1; i >= 0; i--)//Step3:目的配列の作成
            {
                b[--f[a[i]]] = a[i];
            }
            for (i = 0; i < a.Length; i++)//Step4:配列のコピー
            {
                a[i] = b[i];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("度数ソート");
            int[] x = { 22, 5, 11, 32, 98, 68, 70 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x[{0}]:{1}", i, x[i]);
            }

            fsort(x);

            Console.WriteLine("昇順にソートしました。");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x[{0}]:{1}", i, x[i]);
            }

            Console.ReadLine();
        }
    }
}
