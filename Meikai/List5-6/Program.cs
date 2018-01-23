using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_6
{
    class Program
    {
        /// <summary>
        /// 円盤[1]~円盤[no]をx軸からy軸へ移動
        /// </summary>
        /// <param name="no">円盤の枚数</param>
        /// <param name="x">開始軸</param>
        /// <param name="y">目的軸</param>
        static void move(int no,int x, int y) {
            if(no > 1)
            {
                move(no - 1, x, 6 - x - y);//中間軸(開始軸と目的軸以外の軸)は必ず「6-x-y」※6は1軸2軸3軸の合計が6だから。
            }
            Console.WriteLine("円盤[{0}]を{1}軸から{2}軸へ移動", no, x, y);
            if (no > 1)
            {
                move(no - 1, 6 - x - y, y);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ハノイの塔");
            Console.Write("円盤の枚数：");
            string stn = Console.ReadLine();
            n = int.Parse(stn);

            move(n,1,3);

            Console.ReadLine();
        }
    }
}
