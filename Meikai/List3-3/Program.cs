using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("線形探索(番兵法)");
            Console.Write("要素数：");
            string stnx = Console.ReadLine();
            int nx = int.Parse(stnx);

            //要素数nx+1のint型配列を生成
            int[] x = new int[nx+1];
            for (int i = 0; i < nx; i++)
            {
                Console.Write("x[{0}]：", i);
                string stid = Console.ReadLine();
                int id = int.Parse(stid);
                x[i] = id;
            }
            printData(x);

            Console.Write("探す値：");
            string stky = Console.ReadLine();
            int ky = int.Parse(stky);

            //配列xから値がkyである要素を線形探索
            int idx = search(x, nx, ky);
            printData(x);

            if (idx == -1)
            {
                Console.WriteLine("探索に失敗しました。");
            }
            else
            {
                Console.WriteLine("{0}はx[{1}]にあります。", ky, idx);
            }

            Console.ReadLine();
        }
        /// <summary>
        /// 配列xの表示
        /// </summary>
        static void printData(int[] x)
        {
            Console.Write("x[] = {");
            foreach (int k in x)
            {
                System.Console.Write(" {0} ", k);
            }
            Console.Write("}");
            Console.WriteLine();
        }
        /// <summary>
        /// 要素数nxの配列xからkyと一致する要素を線形探索
        /// </summary>
        static int search(int[] x, int nx, int ky)
        {
            int i = 0;
            x[nx] = ky;
            while (true)
            {
                if(x[i] == ky)
                {
                    break;
                }
                i++;
            }
            
            if(i == nx)
            {
                return -1;
            }
            else
            {
                return i;
            }
        }
    }
}
