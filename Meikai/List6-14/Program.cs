using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List6_14
{
    class Program
    {
        static int[] mergebefore(int[] b)
        {
            Console.WriteLine("配列を前半と後半に分割します。");
            int half = b.Length / 2;
            int[] b1 = new int[half];
            int[] b2 = new int[half + 1];

            for (int i = 0; i < half; i++)
            {
                b1[i] = b[i];
            }
            //前半の中身を表示
            Console.WriteLine("mergemerge前半");
            for (int i = 0; i < b1.Length; i++)
            {
                Console.WriteLine("b1[{0}]:{1}", i, b1[i]);
            }
            if (b1.Length != 1)
            {
                mergebefore(b1);
            }

            int j = half;
            for (int i = 0; i < half + 1; i++)
            {
                b2[i] = b[j];
                j++;
            }
            //後半の中身を表示
            Console.WriteLine("mergemerge後半");
            for (int i = 0; i < b2.Length; i++)
            {
                Console.WriteLine("b2[{0}]:{1}", i, b2[i]);
            }

            Console.WriteLine("前半配列b1と後半配列b2を配列b3にソートして格納します。");
            int[] b3 = new int[b1.Length + b2.Length];
            int pb = 0;
            int pc = 0;
            int pd = 0;

            while (pb < b1.Length && pc < b2.Length)
            {
                b3[pd] = (b1[pb] <= b2[pc]) ? b1[pb] : b2[pc];
                if (b1[pb] <= b2[pc])
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
            while (pb < b1.Length)//配列cをすべて配列dに格納している＆配列bに未格納がある場合
            {
                b3[pd++] = b1[pb++];
            }
            while (pc < b2.Length)//配列bをすべて配列dに格納している＆配列cに未格納がある場合
            {
                b3[pd++] = b2[pc++];
            }

            //配列dの中身を表示
            Console.WriteLine("配列b3");
            for (int i = 0; i < b3.Length; i++)
            {
                Console.WriteLine("b3[{0}]:{1}", i, b3[i]);
            }

            return b3;
        }
        static int[] mergeafter(int[] c)
        {
            Console.WriteLine("配列を前半と後半に分割します。");
            int half = c.Length / 2;
            int[] c1 = new int[half];
            int[] c2 = new int[half];

            for (int i = 0; i < half; i++)
            {
                c1[i] = c[i];
            }
            //前半の中身を表示
            Console.WriteLine("mergemerge前半");
            for (int i = 0; i < c1.Length; i++)
            {
                Console.WriteLine("c1[{0}]:{1}", i, c1[i]);
            }
            if (c1.Length != 1)
            {
                mergeafter(c1);
            }

            int j = half;
            for (int i = 0; i < half; i++)
            {
                c2[i] = c[j];
                j++;
            }
            //後半の中身を表示
            Console.WriteLine("mergemerge後半");
            for (int i = 0; i < c2.Length; i++)
            {
                Console.WriteLine("c2[{0}]:{1}", i, c2[i]);
            }

            Console.WriteLine("前半配列b1と後半配列b2を配列b3にソートして格納します。");
            int[] c3 = new int[c1.Length + c2.Length];
            int pb = 0;
            int pc = 0;
            int pd = 0;

            while (pb < c1.Length && pc < c2.Length)
            {
                c3[pd] = (c1[pb] <= c2[pc]) ? c1[pb] : c2[pc];
                if (c1[pb] <= c2[pc])
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
            while (pb < c1.Length)//配列cをすべて配列dに格納している＆配列bに未格納がある場合
            {
                c3[pd++] = c1[pb++];
            }
            while (pc < c2.Length)//配列bをすべて配列dに格納している＆配列cに未格納がある場合
            {
                c3[pd++] = c2[pc++];
            }

            //配列c3の中身を表示
            Console.WriteLine("配列c3");
            for (int i = 0; i < c3.Length; i++)
            {
                Console.WriteLine("c3[{0}]:{1}", i, c3[i]);
            }

            return c3;
        }
        static void mergesort(int[] a,int[] b, int[] c, int half)
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
                b = mergebefore(b);
            }

            int j = half;
            for (int i = 0; i < half + 1; i++)
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
                c = mergeafter(c);
            }

            Console.WriteLine("前半配列bと後半配列cを配列dにソートして格納します。");
            int[] d = new int[b.Length + c.Length];
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

            //配列dの中身を表示
            Console.WriteLine("配列d");
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d[{0}]:{1}", i,d[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 22, 5, 11, 32, 120, 3, 70 };

            //配列aの中身を表示
            Console.WriteLine("配列a");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]:{1}", i, a[i]);
            }

            Console.WriteLine("配列を前半と後半に分割します。");
            int half = a.Length / 2;
            int[] b = new int[half];
            int[] c = new int[half + 1];

            Console.WriteLine("昇順にソートします。");
            mergesort(a,b,c,half);

            Console.WriteLine("昇順にソートしました。");

            Console.ReadLine();
        }
    }
}
