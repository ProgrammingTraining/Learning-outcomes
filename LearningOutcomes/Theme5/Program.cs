using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i=1;
            int result = 0;

            Console.Write("整数を入力してください：");
            input = Console.ReadLine();
            int n = int.Parse(input);
            
            while (i <= n)
            {
                result += i;
                i++;
            }
            Console.WriteLine("1から" + input + "までの和は" + result + "です。");
            Console.ReadLine();
        }
    }
}
