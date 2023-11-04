using ConsoleGame.EQParts;
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
        public int HeroLvl { get; set; }
        public int HeroHP { get; set; }
        public int HeroExp { get; set; }

        public int HeroAttac { get; set; }
        public int HeroArmor { get; set; }
        public double HeroCritChance { get; set; }
        public double HeroCritDeff { get; set; }
        public double HeroIncreaseHeal { get; set; }
        public double HeroIncreaseAtt { get; set; }
        public int HeroMana { get; set; }

        public List<object> HeroEQ = new List<object>();
        public List<object> HeroItems = new List<object>();
        public List<object> HeroScrolls = new List<object>();
        public List<object> HeroHeal = new List<object>();

        

        public Hero(string heroName) 
        {
            HeroName = heroName;
            HeroLvl = 0;
            HeroExp = 45; 
        }

        internal void HeroMenu()
        {
            while (true)
            {
                int option = OptionPicker();

                switch (option)
                {
                    case 0:
                        //cofnij 
                        break;
                    case 1:
                        ShowStats();
                        break;
                    case 2:
                        //LookAtItemsOnMe();
                        break;
                    case 3:
                        DressUp();
                        break;
                    case 4:
                        //Undress();
                        break;
                    case 5:
                        LookAllItems();
                        break;
                    case 6:
                        Generuj();
                        break;
                }
            }
        }
        private int OptionPicker()
        {
            Console.WriteLine("Pick what you want to do?");
            Console.WriteLine("1. Zobacz statystki");
            Console.WriteLine("2. Zobacz założone przedmioty");
            Console.WriteLine("3. Ubierz przedmiot");
            Console.WriteLine("4. Zdejmij przedmiot");
            Console.WriteLine("5. Zobacz ekwipunek");
            Console.WriteLine("6. Generuj przedmioty");

            int option = int.Parse(Console.ReadLine());
            //Console.Clear();
            return option;
        }
        //1
        private void ShowStats()
        {
            Console.WriteLine("Statystki:");
            Console.WriteLine($"Name:{HeroName} LVL: {HeroLvl}");
            ShowExp();
            Console.WriteLine("");
            Console.WriteLine($"HP: {HeroHP}\nAttac: {HeroAttac}\nArmor: {HeroArmor}\nCrit chance: {HeroCritChance}\nCrit deff: {HeroCritDeff}\n" +
                $"Increase heal bonus: {HeroIncreaseHeal}\nIncrease attac bonus: {HeroIncreaseAtt}\nMana: {HeroMana}\n");          
        }
        private void ShowExp()
        {
            Console.WriteLine($"EXP ({HeroExp}): ");
            int numHash = HeroExp / 10;
            int numMinus = 10 - numHash;
            Console.Write("[");
            for (int i = 0; i < 10; i++) 
            {
                if(i < numHash) { Console.Write("#"); }
                else { Console.Write("-"); }
            }
            Console.Write("]");
        }
        //3
        private void DressUp()
        {
            Console.WriteLine("Give number of item to wear: ");
            int itemID = (int)Convert.ToInt64(Console.ReadLine());
            object itemToWear = HeroItems[itemID];

            if (HeroEQ.Contains(itemToWear))
            {
                ((IItems)itemToWear).SentenceType();
            }
            else
            {
                Console.WriteLine("Założyłeś przedmiot!");
                HeroEQ.Add(itemToWear);
                GetStats();
            }
        }
        private void GetStats()
        {
            List<Helm> helms = HeroEQ.OfType<Helm>().ToList();
            List<Chestplate> chestplates = HeroEQ.OfType<Chestplate>().ToList();
            List<Pants> pants = HeroEQ.OfType<Pants>().ToList();
            List<Shoes> shoes = HeroEQ.OfType<Shoes>().ToList();
            List<Gloves> gloves = HeroEQ.OfType<Gloves>().ToList();

            HeroArmor = 0;
            HeroHP = 0;
            HeroCritDeff = 0;
            HeroIncreaseHeal = 0;
            HeroIncreaseAtt = 0;
            HeroMana = 0;
            if (helms.Count == 1)
            {
                HeroArmor += helms[0].Armor;
                HeroHP += helms[0].Life;
                HeroCritDeff += helms[0].CritDeff;
            }
            if (chestplates.Count == 1)
            {
                HeroArmor += chestplates[0].Armor;
                HeroHP += chestplates[0].Life;
                HeroIncreaseHeal += chestplates[0].IncreaseHeal;
            }
            if (pants.Count == 1)
            {
                HeroArmor += pants[0].Armor;
                HeroHP += pants[0].Life;
                HeroIncreaseAtt += pants[0].IncreaseAtt;
            }
            if (shoes.Count == 1)
            {
                HeroArmor += shoes[0].Armor;
                HeroHP += shoes[0].Life;
                HeroMana += shoes[0].Mana;
            }
            if (gloves.Count == 1)
            {
                HeroArmor += gloves[0].Armor;
                HeroHP += gloves[0].Life;
                HeroMana += gloves[0].Mana;
            }                
        }
        //5
        private void LookAllItems()
        {
            List<Helm> helms = HeroItems.OfType<Helm>().ToList();
            List<Chestplate> chestplates = HeroItems.OfType<Chestplate>().ToList();
            List<Pants> pants = HeroItems.OfType<Pants>().ToList();
            List<Shoes> shoes = HeroItems.OfType<Shoes>().ToList();
            List<Gloves> gloves = HeroItems.OfType<Gloves>().ToList();
            List<string> titles = new List<string>
            {
                "Number", "Name", "Armor", "Life", "Increase Heal", "Increase Attack", "Mana", "Crit Deff"
            };


            /* Console.WriteLine("+----------+----------+----------+----------+---------------+----------------+------+");
             Console.WriteLine("|Number:   |Name:     |Armor:    |Life:     |Increase Heal: |Increase Attac: |Mana: |");
             Console.WriteLine("+----------+----------+----------+----------+---------------+----------------+------+");     */

            int count = 0;
            /*Console.WriteLine("Number {0}", count);
            ((IItems)item).ShowDetals();
            Console.WriteLine();*/

            int szerokoscKolumny = titles.Max(n => n.Length) + 2;
            int szerokoscNaglowka = szerokoscKolumny * titles.Count + titles.Count + 1;

            Console.WriteLine(new string('+', szerokoscNaglowka));
            Console.Write("|");
            for (int i = 0; i < titles.Count; i++)
            {
                Console.Write($" {titles[i].PadRight(szerokoscKolumny)} |");
            }
            Console.WriteLine("\n" + new string('+', szerokoscNaglowka));



            foreach (Helm helm in helms)
            {

            }
            count = 0;
        }
        //6
        private void Generuj()
        {
            Helm helm1 = new Helm("Dobry Helm", 10, 5, 1.2);
            Chestplate chestplate1 = new Chestplate("Dobra Klata", 15, 10, 1.5);
            Pants pants1 = new Pants("Dobre Spodenki", 3, 2, 0.3);
            Shoes shoes1 = new Shoes("Dobre Cichobiegi", 11, 0, 20);
            Gloves gloves1 = new Gloves("Dobre Rękawice", 1, 1, 5);

            Gloves gloves2 = new Gloves("Dobre Rękawice2", 1, 1, 5);

            HeroItems.Add(helm1);
            HeroItems.Add(chestplate1);
            HeroItems.Add(pants1);
            HeroItems.Add(shoes1);
            HeroItems.Add(gloves1);
            HeroItems.Add(gloves2);
        }





















































        /* public void GetItem(Item item)
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
         }*/
    }
}
