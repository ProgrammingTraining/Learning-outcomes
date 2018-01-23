using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_8
{
    class Program
    {
        static int[] flag = new int[4];
        static int[] pos = new int[4];
        static void print()
        {
            int i;
            for (i = 0; i < 4; i++)
            {
                Console.Write(pos[i]);
            }
            Console.WriteLine();
        }
        static void set(int i)
        {
            int j;
            for (j = 0; j < 4; j++)
            {
                if (flag[j] == 0) {
                    pos[i] = j;
                    if (i == 3)
                    {
                        print();
                    }
                    else
                    {
                        flag[j] = 1;
                        set(i + 1);
                        flag[j] = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int i;
            for(i = 0; i < 4; i++)
            {
                flag[i] = 0;
            }
            set(0);

            Console.ReadLine();
        }
    }
}
