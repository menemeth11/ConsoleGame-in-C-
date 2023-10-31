using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal class Gloves : IItems
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Life { get; set; }
        public int Mana { get; set; }
        public EQType EQType { get; set; }

        public Gloves(string GName, int GArmor, int GLife, int GMana)
        {
            Name = GName;
            Armor = GArmor;
            Life = GLife;
            Mana = GMana;
            EQType = EQType.gloves;
        }

        public void ShowDetals()
        {
            Console.WriteLine($"Statystyki przedmiotu: \n\tNazwa: {this.Name} \n\tArmor: {this.Armor} \n\tLife: {this.Life} \n\tMana: {this.Mana} \n\tTemporary TYPE: {this.EQType}");
        }
        public void SentenceType()
        {
            Console.WriteLine($"Masz już na sobie przedmiot typu: {this.EQType}! \nZdejmij go aby założyć wybrany przedmiot!");
        }
    }
}
