using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal class Chestplate : IItems
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Life { get; set; }
        public double IncreaseHeal { get; set; }
        public EQType EQType { get; set; }

        public Chestplate(string CName, int CArmor, int CLife, double CIncreaseHeal)
        {
            Name = CName;
            Armor = CArmor;
            Life = CLife;
            IncreaseHeal = CIncreaseHeal;
            EQType = EQType.chestplate;
        }

        public void ShowDetals()
        {
            Console.WriteLine($"Statystyki przedmiotu: \n\tNazwa: {this.Name} \n\tArmor: {this.Armor} \n\tLife: {this.Life} \n\tIncrease Heal: {this.IncreaseHeal} \n\tTemporary TYPE: {this.EQType}");
        }
        public void SentenceType()
        {
            Console.WriteLine($"Masz już na sobie przedmiot typu: {this.EQType}! \n Zdejmij go aby założyć wybrany przedmiot!");
        }

    }
}
