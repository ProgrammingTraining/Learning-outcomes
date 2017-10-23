using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4
{
    class Program
    {

        static void Main(string[] args)
        {
            int result = 0;
            for (int i=1; i<=10;i++)
            {
                result += i;
            }
            Console.WriteLine("1から10までの和は"+ result + "です。");
            Console.ReadLine();
        }
    }
}
