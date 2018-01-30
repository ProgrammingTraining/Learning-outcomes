using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List6_15
{
    class Program
    {
        /// <summary>
        /// x[left]～x[right]をヒープ化
        /// </summary>
        static void downheap(int[] x,int left, int right)
        {
            int temp = x[left];//根(最大値)
            int child;
            int parent;

            for (parent = left; parent < (right + 1) / 2; parent = child)
            {
                int cl = parent * 2 + 1; //左の子
                int cr = cl + 1;         //右の子

                child = (cr <= right && x[cr] > x[cl]) ? cr : cl; //大きいほう

                if(temp >= x[child])//根が子以上
                {
                    break;
                }

                x[parent] = x[child];
            }
            x[parent] = temp;
        }
        static void heapsort(int[] x)
        {
            int i;
            for (i = (x.Length - 1) / 2; i >= 0; i--)//配列をヒープ化
            {
                downheap(x, i, x.Length - 1);
            }
            for (i = (x.Length - 1); i > 0; i--)//根(最大値)を取り出して、配列の末尾と交換し、残りを再ヒープ化
            {
                do//sort
                {
                    int n;
                    n = x[0];
                    x[0] = x[i];
                    x[i] = n;
                } while (false);

                downheap(x, 0, i - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ヒープソート");
            int[] x = { 22, 5, 11, 32, 120, 68, 70 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x[{0}]:{1}", i, x[i]);
            }
            
            heapsort(x);

            Console.WriteLine("昇順にソートしました。");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x[{0}]:{1}", i, x[i]);
            }

            Console.ReadLine();
        }
    }
}
