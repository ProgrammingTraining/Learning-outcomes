using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, i, j;

            int[] a = {4,5,2,3};
            length = a.Length - 1;

            for(i = 0; i <= length; i++)
            {
                Console.Write("a[" + i + "]=" + a[i]+"|");
                for (j = 1; j <= a[i]; j++)
                {
                    Console.Write("*");
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
