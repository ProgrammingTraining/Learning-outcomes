using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme6
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("1から100までの3の倍数の和は" + result + "です。");
            Console.ReadLine();
        }
    }
}
