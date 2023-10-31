using ConsoleGame.EQParts;
using System;
using System.ComponentModel.Design;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game RPGConsole = new Game("RPGConsole");
            //RPGConsole.Start();
            Console.WriteLine("Podaj nazwę swojego bohatera!");
            string NameForHero = "Bob"; //Console.ReadLine();
            Hero hero = new Hero(NameForHero);

            while (true)
            {
                int option = RPGConsole.Menu();

                switch (option)
                {
                    case 0:
                        
                        break;
                    case 1:
                        hero.HeroMenu();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                }
            }
        }
    }
}