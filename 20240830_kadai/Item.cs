﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240830_kadai
{
    internal class Item
    {
        public int id;
        public string name;
        public int price;

        public Item(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
