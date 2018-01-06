using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二分探索");
            Console.Write("要素数：");
            string stnx = Console.ReadLine();
            int nx = int.Parse(stnx);

            //要素数nx+1のint型配列を生成
            Console.WriteLine("昇順に入力してください。");
            int[] x = new int[nx];
            for (int i = 0; i < nx; i++)
            {
                Console.Write("x[{0}]：", i);
                string stid = Console.ReadLine();
                int id = int.Parse(stid);
                x[i] = id;
                if(i > 0) {
                    //昇順じゃなければ再入力
                    if (x[i] < x[i - 1])
                    {
                        do
                        {
                            Console.Write("x[{0}]：", i);
                            stid = Console.ReadLine();
                            id = int.Parse(stid);
                            x[i] = id;
                        } while (x[i] < x[i - 1]);
                    }
                }
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
        /// 要素数nxの配列xからkyと一致する要素を二分探索
        /// </summary>
        static int search(int[] x, int nx, int ky)
        {
            int pl = 0;//探索範囲先頭の添字
            int pr = nx - 1;//探索範囲末尾の添字
            int pc;//探索範囲中央の添字

            do {
                pc = (pl + pr) / 2;
                if(x[pc] == ky)
                {
                    return pc;//探索成功
                }
                else if(x[pc] < ky)
                {
                    pl = pc + 1;
                }
                else
                {
                    pr = pc - 1;
                }
            } while (pl <= pr);
            return -1;//探索失敗
        }
    }
}
