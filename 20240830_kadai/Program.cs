using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20240830_kadai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("いらっしゃいませ！");
            Console.ReadLine();

            List<Item> itemList = new List<Item>() {
            new Item(1, "ひのきのぼう", 8),
            new Item(2, "こんぼう", 30),
            new Item(3,"どうのつるぎ",120)
        };

            int money = 1000;
            int number;
            Console.WriteLine("いらっしゃいませ！");
            Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("所持金:" + money);
                Console.WriteLine("アイテム" + itemList[0].id + "." + itemList[0].name + ":" + itemList[0].price);
                Console.WriteLine("アイテム" + itemList[1].id + "." + itemList[1].name + ":" + itemList[1].price);
                Console.WriteLine("アイテム" + itemList[2].id + "." + itemList[2].name + ":" + itemList[2].price);

                Console.WriteLine("0キーで終了します。");

                int.TryParse(Console.ReadLine(), out number);

            }while(number > 0);
        }
    }
}

