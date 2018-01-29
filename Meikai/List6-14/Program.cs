using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List6_14
{
    class Program
    {
        static int[] mergemerge(int[] e)
        {
            Console.WriteLine("配列を前半と後半に分割します。");
            int half = e.Length / 2;
            int afterMax;
            if (e.Length % 2 == 1)//奇数
            {
                afterMax = half + 1 ;
            }
            else
            {
                afterMax = half;
            }

            int[] before = new int[half];
            int[] after = new int[afterMax];


            Console.WriteLine("mergemerge前半");
            for (int i = 0; i < half; i++)
            {
                before[i] = e[i];
            }
            //前半の中身を表示
            for (int i = 0; i < before.Length; i++)
            {
                Console.WriteLine("before[{0}]:{1}", i, before[i]);
            }
            if (before.Length != 1)
            {
                before = mergemerge(before);
            }

            Console.WriteLine("mergemerge後半");
            int j = half;
            for (int i = 0; i < afterMax; i++)
            {
                after[i] = e[j];
                j++;
            }
            //後半の中身を表示
            for (int i = 0; i < after.Length; i++)
            {
                Console.WriteLine("after[{0}]:{1}", i, after[i]);
            }
            if (after.Length != 1)
            {
                after = mergemerge(after);
            }

            Console.WriteLine("前半配列beforeと後半配列afterを配列fにソートして格納します。");
            int[] f = new int[before.Length + after.Length];
            int pb = 0;
            int pc = 0;
            int pd = 0;

            while (pb < before.Length && pc < after.Length)
            {
                f[pd] = (before[pb] <= after[pc]) ? before[pb] : after[pc];
                if (before[pb] <= after[pc])
                {
                    pb++;
                }
                else
                {
                    pc++;
                }
                pd++;
            }

            //比較対象のない残り物の格納
            while (pb < before.Length)//配列cをすべて配列dに格納している＆配列bに未格納がある場合
            {
                f[pd++] = before[pb++];
            }
            while (pc < after.Length)//配列bをすべて配列dに格納している＆配列cに未格納がある場合
            {
                f[pd++] = after[pc++];
            }

            //配列dの中身を表示
            Console.WriteLine("配列f");
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("f[{0}]:{1}", i, f[i]);
            }

            return f;
        }
        static void mergesort(int[] a,int[] b, int[] c,int[]d, int half, int afterMax)
        {
            
            for (int i = 0; i < half; i++)
            {
                b[i] = a[i];
            }
            //前半の中身を表示
            Console.WriteLine("前半");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("b[{0}]:{1}", i, b[i]);
            }
            if(b.Length != 1)
            {
                b = mergemerge(b);
            }

            int j = half;
            for (int i = 0; i < afterMax; i++)
            {
                c[i] = a[j];
                j++;
            }
            //後半の中身を表示
            Console.WriteLine("後半");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("c[{0}]:{1}", i, c[i]);
            }
            if (c.Length != 1)
            {
                c = mergemerge(c);
            }

            Console.WriteLine("前半配列bと後半配列cを配列dにソートして格納します。");
            int pb = 0;
            int pc = 0;
            int pd = 0;

            while (pb < b.Length && pc < c.Length)
            {
                d[pd] = (b[pb] <= c[pc]) ? b[pb] : c[pc];
                if (b[pb] <= c[pc])
                {
                    pb++;
                }
                else
                {
                    pc++;
                }
                pd++;
            }

            //比較対象のない残り物の格納
            while (pb < b.Length)//配列cをすべて配列dに格納している＆配列bに未格納がある場合
            {
                d[pd++] = b[pb++];
            }
            while (pc < c.Length)//配列bをすべて配列dに格納している＆配列cに未格納がある場合
            {
                d[pd++] = c[pc++];
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 5, 32, 120, 3 };

            //配列aの中身を表示
            Console.WriteLine("配列a");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]:{1}", i, a[i]);
            }

            Console.WriteLine("配列を前半と後半に分割します。");
            int half = a.Length / 2;
            int afterMax;
            if (a.Length % 2 == 1)//奇数
            {
                afterMax = half + 1;
            }
            else
            {
                afterMax = half;
            }
            int[] b = new int[half];
            int[] c = new int[afterMax];
            int[] d = new int[b.Length + c.Length];

            mergesort(a,b,c,d,half, afterMax);

            Console.WriteLine("昇順にソートしました。");
            //配列dの中身を表示
            Console.WriteLine("配列d");
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d[{0}]:{1}", i, d[i]);
            }

            Console.ReadLine();
        }
    }
}
