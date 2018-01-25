using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List6_13
{
    class Program
    {
        static void merge(int[] a, int[] b, int[] c)
        {
            int pa = 0;
            int pb = 0;
            int pc = 0;

            while (pa < a.Length && pb < b.Length)
            {
                //「A <= B」はAがB以下の場合に true を返し、それ以外の場合に　false を返す演算子だよ！
                //「(true or false) ? A : B」は()内が true の時　A　、 false　の時　B　を返す条件演算子だよ！
                c[pc++] = (a[pa] <= b[pb]) ? a[pa++] : b[pb++];
            }

            //比較対象のない残り物の格納
            while (pa < a.Length)//配列bをすべて配列cに格納している＆配列aに未格納がある場合
            {
                c[pc++] = a[pa++];
            }
            while (pb < b.Length)//配列aをすべて配列cに格納している＆配列bに未格納がある場合
            {
                c[pc++] = b[pb++];
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1,3,5,7,9,11};
            int[] b = { 0,1,2,3,8,15,19};
            int[] c = new int[a.Length + b.Length];

            //配列aの中身を表示
            Console.WriteLine("配列a");
            Console.WriteLine("a[0]:{0}",a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    Console.WriteLine("a[{0}]:{1}", i, a[i]);
                } while (a[i] < a[i - 1]);
            }

            //配列bの中身を表示
            Console.WriteLine("配列b");
            Console.WriteLine("b[0]:{0}", b[0]);
            for (int i = 1; i < b.Length; i++)
            {
                do
                {
                    Console.WriteLine("b[{0}]:{1}", i, b[i]);
                } while (b[i] < b[i - 1]);
            }

            //配列aとbをマージしてcに格納
            merge(a, b, c);

            Console.WriteLine("配列aとbをマージしてcに格納しました。");

            //配列cの中身を表示
            Console.WriteLine("配列c");
            for (int i = 0; i < a.Length + b.Length; i++)
            {
                Console.WriteLine("c[{0}]:{1}", i, c[i]);
            }

            Console.ReadLine();
        }
    }
}
