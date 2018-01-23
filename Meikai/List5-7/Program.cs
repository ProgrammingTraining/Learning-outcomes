using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_7
{
    class Program
    {
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
                pos[i] = j;
                if(i == 3)
                {
                    print();
                }
                else
                {
                    set(i + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            set(0);

            Console.ReadLine();
        }
    }
}
