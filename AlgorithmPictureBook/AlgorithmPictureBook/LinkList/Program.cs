using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

            Console.WriteLine("[Linked-List Test]");
            Console.WriteLine("command = list/add/insert/delete/clear/quit");
            bool quitCheck = false;
            while (quitCheck == false)
            {
                Console.Write("command:");
                string cmd = Console.ReadLine();
                if (cmd == "quit")//終了
                {
                    Console.WriteLine("終了");
                    quitCheck = true;
                }
                else if (cmd == "list")//一覧を表示
                {
                    Console.WriteLine("一覧を表示");
                    listData(list);
                }
                else if (cmd == "add")//データを追加
                {
                    Console.WriteLine("データを追加");
                    string[] inputData = enterData();
                    int id = int.Parse(inputData[0]);

                    KeyValuePair<int, string> addData = new KeyValuePair<int, string>(id, inputData[1]);
                    list.Add(addData);
                }
                else if (cmd == "insert")//データを挿入
                {
                    Console.WriteLine("データを挿入");
                    Console.Write("何番目のデータの後に挿入しますか：");
                    string inputIndexNumber = Console.ReadLine();
                    int indexNumber = int.Parse(inputIndexNumber);
                    string[] inputData = enterData();
                    int id = int.Parse(inputData[0]);

                    KeyValuePair<int, string> addData = new KeyValuePair<int, string>(id, inputData[1]);
                    list.Insert(indexNumber, addData);
                }
                else if (cmd == "delete")//データを削除
                {
                    Console.WriteLine("データを削除");
                    Console.Write("何番目のデータを削除しますか：");
                    string inputIndexNumber = Console.ReadLine();
                    int indexNumber = int.Parse(inputIndexNumber);
                    list.RemoveAt(indexNumber-1);
                }
                else if (cmd == "clear")//データをすべて削除
                {
                    Console.WriteLine("データをすべて削除");
                    list.Clear();
                }
                else
                {
                    Console.WriteLine("既定のコマンドではありません。もう一度入力してください。");
                }
            }
            Console.ReadLine();
        }
        static string[] enterData()
        {
            Console.WriteLine("追加するデータを入力してください");
            Console.Write("id：");
            string inputId = Console.ReadLine();
            Console.Write("name：");
            string name = Console.ReadLine();
            string[] inputData = { inputId, name };
            return inputData;
        }
        /// <summary>
        /// 一覧を表示
        /// </summary>
        static void listData(List<KeyValuePair<int, string>> list)
        {
            Console.WriteLine("No.  data");
            Console.WriteLine("---- ----");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0:0000} id={1} name={2}", i + 1, list[i].Key, list[i].Value);
            }
        }
    }
}
