using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Game
    {
        public string GameName;

        public Game(string gameName)
        {
            GameName = gameName;
        }       
        public void Start()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************************");
            Wait(1000);
            Console.WriteLine("*  _____  _____   _____  _____                      _      *");
            Wait(1000);
            Console.WriteLine(@"* |  __ \|  __ \ / ____|/ ____|                    | |     *");
            Wait(1000);
            Console.WriteLine("* | |__) | |__) | |  __| |     ___  _ __  ___  ___ | | ___ *");
            Wait(1000);
            Console.WriteLine(@"* |  _  /|  ___/| | |_ | |    / _ \| '_ \/ __|/ _ \| |/ _ \*");
            Wait(1000);
            Console.WriteLine(@"* | | \ \| |    | |__| | |___| (_) | | | \__ \ (_) | |  __/*");
            Wait(1000);
            Console.WriteLine(@"* |_|  \_\_|     \_____|\_____\___/|_| |_|___/\___/|_|\___|*");
            Wait(1000);
            Console.WriteLine("************************************************************");
            Wait(2000);
            Console.ResetColor();
            Console.Clear();
            Wait(3000);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            ShowGameName();
            Console.ResetColor();
        }
        public void ShowGameName()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("*  _____  _____   _____  _____                      _      *");
            Console.WriteLine(@"* |  __ \|  __ \ / ____|/ ____|                    | |     *");
            Console.WriteLine("* | |__) | |__) | |  __| |     ___  _ __  ___  ___ | | ___ *");
            Console.WriteLine(@"* |  _  /|  ___/| | |_ | |    / _ \| '_ \/ __|/ _ \| |/ _ \*");
            Console.WriteLine(@"* | | \ \| |    | |__| | |___| (_) | | | \__ \ (_) | |  __/*");
            Console.WriteLine(@"* |_|  \_\_|     \_____|\_____\___/|_| |_|___/\___/|_|\___|*");
            Console.WriteLine("************************************************************");
        }
        private void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            Console.Beep();
        }
    }
}
