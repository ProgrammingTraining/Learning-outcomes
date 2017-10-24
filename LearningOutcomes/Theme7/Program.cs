using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme7
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string inputMultiple, inputLimit;

            Console.Write("何の倍数：");
            inputMultiple = Console.ReadLine();
            int multiple = int.Parse(inputMultiple);

            Console.Write("どこまで：");
            inputLimit = Console.ReadLine();
            int limit = int.Parse(inputLimit);

            for (int i = 1; i <= limit; i++)
            {
                if (i % multiple == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("1から"+ limit + "までの"+ multiple+"の倍数の和は" + result + "です。");
            Console.ReadLine();
        }
    }
}
