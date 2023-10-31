using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal class Shoes : IItems
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Life { get; set; }
        public int Mana { get; set; }
        public EQType EQType { get; set; }

        public Shoes(string SName, int SArmor, int SLife, int SMana)
        {
            Name = SName;
            Armor = SArmor;
            Life = SLife;
            Mana = SMana;
            EQType = EQType.shoes;
        }

        public void ShowDetals()
        {
            Console.WriteLine($"Statystyki przedmiotu: \n\tNazwa: {this.Name} \n\tArmor: {this.Armor} \n\tLife: {this.Life} \n\tMana: {this.Mana} \n\tTemporary TYPE: {this.EQType}");
        }
        public void SentenceType()
        {
            Console.WriteLine($"Masz już na sobie przedmiot typu: {this.EQType}! \n Zdejmij go aby założyć wybrany przedmiot!");
        }
    }
}
