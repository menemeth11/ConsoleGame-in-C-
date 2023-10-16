using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Item
    {
        public enum EQTypes
        { //I know the numbers are automatic
            helm = 0,
            zbroja = 1,
            spodnie = 2,
            buty = 3,
            rekawice = 4
        }
        public string ItemName { get; set; }
        public EQTypes ItemType { get; set; }
        public int ItemAtack { get; set; }

        public Item(string itemName, EQTypes typ, int atack)
        {
            ItemName = itemName;
            ItemType = typ;
            ItemAtack = atack;
        }

    }
}
