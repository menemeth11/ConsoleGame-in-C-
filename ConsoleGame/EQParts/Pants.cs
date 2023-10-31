using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal class Pants : IItems
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Life { get; set; }
        public double IncreaseAtt { get; set; }
        public EQType EQType { get; set; }

        public Pants(string PName, int PArmor, int PLife, double PIncreaseAtt)
        {
            Name = PName;
            Armor = PArmor;
            Life = PLife;
            IncreaseAtt = PIncreaseAtt;
            EQType = EQType.pants;
        }

        public void ShowDetals()
        {
            Console.WriteLine($"Statystyki przedmiotu: \n\tNazwa: {this.Name} \n\tArmor: {this.Armor} \n\tLife: {this.Life} \n\tIncrease Attack: {this.IncreaseAtt} \n\tTemporary TYPE: {this.EQType}");
        }
        public void SentenceType()
        {
            Console.WriteLine($"Masz już na sobie przedmiot typu: {this.EQType}! \n Zdejmij go aby założyć wybrany przedmiot!");
        }
    }
}
