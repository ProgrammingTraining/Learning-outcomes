using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string fileName = @"../abc.txt";

            if (File.Exists(fileName))
            {
                StreamReader fp = new StreamReader(fileName);
                while (fp.Peek() >= 0)
                {
                    string text = fp.ReadLine();
                    Console.WriteLine("{0:0000}:{1}", i, text);
                    i++;
                }
                fp.Close();
            }
            else
            {
                Console.WriteLine("'" + fileName + "'は存在しません。");
            }
            Console.ReadLine();
        }
    }
}
