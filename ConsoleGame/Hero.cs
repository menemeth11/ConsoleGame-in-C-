using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Hero
    {
        public string HeroName;
        public List<Item> HeroItem = new List<Item>();

        public int HeroLvl { get; set; }
        public int HeroAttac { get; set; }
        public int HeroDeff { get; set; }
        public int HeroMana { get; set; }

        

        public Hero(string heroName) 
        {
            HeroName = heroName;
            HeroLvl = 0;
        }

        public void GetItem(Item item)
        {
            if (HeroItem.Any(i => i.ItemType == item.ItemType))
            {
                Console.WriteLine($"Nie możesz założyć przedmiotu typu {item.ItemType} ponieważ masz już jeden założony. Zdejmij go!");
            }
            else
            {
                HeroItem.Add(item);
            }
        }

        internal void ShowEQ()
        {
            if(HeroItem.Count <= 0)
            {
                Console.WriteLine("Jestes goły i wesoły\n");
            }
            else
            {
                foreach (Item item in HeroItem)
                    Console.WriteLine($"Część garderoby: {item.ItemName} \nTypu: {item.ItemType} \nZ atakiem: {item.ItemAtack}\n");
            }

        }

        internal void Unequip(Item item)
        {
            HeroItem.Remove(item);
            Console.WriteLine($"Zdjęto: {item.ItemName}");
        }
    }
}
