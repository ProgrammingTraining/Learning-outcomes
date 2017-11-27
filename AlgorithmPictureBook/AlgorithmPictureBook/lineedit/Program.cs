using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lineedit
{
    class Program
    {
        static string fname = null;
        static string[] buf;
        static int lines = 0;
        static int row, cal;
        static void Main(string[] args)
        {
            bool exitCheck = true;
            while (exitCheck == true)
            {
                Console.Write("command:");
                string cmd = Console.ReadLine();
                if (cmd == "fopen")
                {
                    openFile();
                }
                else if (cmd == "fclose")
                {
                    closeFile();
                }
                else if (cmd == "fsave")
                {
                    saveFile();
                }
                else if (cmd == "list")
                {
                    listLines();
                }
                else if (cmd == "gotoln")
                {
                    gotoLine();
                }
                else if (cmd == "inss")
                {
                    insertString();
                }
                else if (cmd == "dels")
                {
                    deleteString();
                }
                else if (cmd == "help")
                {
                    showHelp();
                }
                else if (cmd == "exit")
                {
                    exitCheck = false;
                }
                else
                {
                    Console.WriteLine("既定のコマンドではありません。もう一度入力してください。");
                }
            }
        }
        //ファイル名の入力
        static void enterFileName()
        {
            bool exist = true;
            while (exist == true)
            {
                Console.Write("filename:");
                fname = Console.ReadLine();
                if (File.Exists(fname))//ファイルが存在するか
                {
                    Console.WriteLine("'" + fname + "'を実行します。");
                    exist = false;
                }
                else
                {
                    Console.WriteLine("'" + fname + "'は存在しません。もう一度入力してください。");
                    exist = true;
                }
            }
        }
        //ファイルの行数カウント
        static void countLines()
        {   
            string[] lineBuf = File.ReadAllLines(fname);
            lines = lineBuf.Length;
        }
        //バッファ、ファイル名、行数の初期化
        static void clearBuffer()
        {
            fname = null;
            buf = null;
            lines = 0;
        }
        //メモリを確保してファイルを読み込む
        static void openFile()
        {
            enterFileName();
            countLines();
            //ファイルの読み込み
            buf = File.ReadAllLines(fname);
            Console.WriteLine("{0}行読み込みました。", lines);
        }
        static void closeFile()
        {
            if (fname == null)
            {
                return;
            }
            bool saveCheck = false;
            while (saveCheck == false)
            {
                Console.WriteLine("保存しますか？(y or n):");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    saveFile();
                    clearBuffer();
                    saveCheck = true;
                }
                else if (ans == "n")
                {
                    saveCheck = true;
                    clearBuffer();
                }
                else
                {
                    Console.Write("もう一度入力してください。：");
                    saveCheck = false;
                }

                Console.WriteLine("メモリ消去しました。");
            }
        }
        static void saveFile()
        {
            if (fname == null)
            {
                return;
            }
            enterFileName();
            countLines();
            StreamWriter fp = new StreamWriter(fname);
            
            int n = 1;
            while (lines >= n)
            {
                string stBuf = buf[n - 1];
                fp.WriteLine(stBuf);
                n++;
            }
            fp.Close();
            Console.WriteLine("保存しました。");
        }
        //ファイル全行リスト表示
        static void listLines()
        {
            if (fname == null)
            {
                return;
            }
            int n = 0;
            while (lines > n)
            {
                string text = buf[n];
                Console.WriteLine("{0:0000}:{1}", n, text);
                n++;
            }
        }
        static void gotoLine()
        {
            if (fname == null)
            {
                return;
            }
            Console.Write("行番号：");
            string inputRow = Console.ReadLine();
            row = int.Parse(inputRow);
            if (row < 0 || row > lines-1)
            {
                return;
            }

            string myline = buf[row];
            Console.WriteLine("{0:0000}:{1}", row, myline);
        }
        static void enterPosition()
        {
            Console.Write("行番号：");
            string inputRow = Console.ReadLine();
            row = int.Parse(inputRow);

            Console.Write("桁番号：");
            string inputCal = Console.ReadLine();
            cal = int.Parse(inputCal);
        }
        static void insertString()
        {
            if (fname == null)
            {
                return;
            }
            enterPosition();//行と列の指定
            if (row < 0 || lines <= row)
            {
                Console.WriteLine("挿入出来ません。");
                return;
            }
            cal -= 1;
            string myline = buf[row];
            int mylineLen = myline.Length;
            if (cal < 0 || mylineLen < cal)
            {
                Console.WriteLine("挿入出来ません。");
                return;
            }

            Console.Write("挿入する文字：");
            string insstr = Console.ReadLine();
            
            myline = myline.Insert(cal, insstr);
            buf[row] = myline;
            Console.WriteLine("{0}行{1}文字目に{2}を挿入しました。", row, cal+1, insstr);
            Console.WriteLine("{0:0000}:{1}", row, myline);
        }
        static void deleteString()
        {
            if (fname == null)
            {
                return;
            }
            enterPosition();//行と列の指定
            if (row < 0 || lines <= row)
            {
                Console.WriteLine("削除出来ません。");
                return;
            }

            cal -= 1;
            string myline = buf[row];
            int mylineLen = myline.Length;
            if (cal < 0 || mylineLen <= cal)
            {
                Console.WriteLine("削除出来ません。");
                return;
            }

            int delnum = 0;
            Console.Write("文字数：");
            string inputDelnum = Console.ReadLine();
            delnum = int.Parse(inputDelnum);
            if (delnum < 0 || delnum > mylineLen - cal)
            {
                Console.WriteLine("削除出来ません。");
                return;
            }
            
            myline = myline.Remove(cal,delnum);
            buf[row] = myline;
            Console.WriteLine("{0}行{1}文字目から{2}文字を削除しました。",row, cal+1, delnum);
            Console.WriteLine("{0:0000}:{1}", row, myline);
        }
        static void showHelp()
        {

            Console.WriteLine("COMMAND HELP:help");
            Console.WriteLine("LOAD FILE:fopen");
            Console.WriteLine("RELEASE BUFFER:fclose");
            Console.WriteLine("SAVE FILE:fsave");
            Console.WriteLine("SHOW ALL LINES:list");
            Console.WriteLine("SHOW SIHNGLE LINE:gotoln");
            Console.WriteLine("INSERT STRING:inss");
            Console.WriteLine("DELETE STRING:dels");
            Console.WriteLine("プログラム終了：exit");
        }
    }
}
