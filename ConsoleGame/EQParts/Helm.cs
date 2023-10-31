using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal class Helm : IItems
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Life { get; set; }
        public double CritDeff { get; set; }
        public EQType EQType { get; set; }

        public Helm(string HName, int HArmor, int HLife, double HCritDeff)
        {
            Name = HName;
            Armor = HArmor;
            Life = HLife;
            CritDeff = HCritDeff;
            EQType = EQType.helm;
        }

        public void ShowDetals()
        {
            Console.WriteLine($"Statystyki przedmiotu: \n\tNazwa: {this.Name} \n\tArmor: {this.Armor} \n\tLife: {this.Life} \n\tCritDeff: {this.CritDeff} \n\tTemporary TYPE: {this.EQType}");
        }

        public void SentenceType()
        {
            Console.WriteLine($"Masz już na sobie przedmiot typu: {this.EQType}! \n Zdejmij go aby założyć wybrany przedmiot!");
        }
    }
}
