using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.EQParts
{
    internal interface IItems
    {
        string Name { get; set; }
        int Armor { get; set; }
        int Life { get; set; }
        EQType EQType { get; set; }

        void ShowDetals() { Console.WriteLine("Przedmiot bez interpretacji xD"); }
        void SentenceType();  
    }
}
