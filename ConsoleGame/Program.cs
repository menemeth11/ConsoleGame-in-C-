namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game RPGConsole = new Game("RPGConsole");
            //RPGConsole.Start();

            Hero hero = new Hero("Bob");

            Item miecz = new Item("Super Miecz", Item.EQTypes.zbroja, 10);
            Item miecz2 = new Item("Super Miecz2", Item.EQTypes.zbroja, 12);
            Item czapka = new Item("Niewidka", Item.EQTypes.helm, 12);

            hero.ShowEQ();
            hero.GetItem(miecz);
            hero.ShowEQ();
            //hero.GetItem(czapka);
            //hero.ShowEQ();
            hero.GetItem(miecz2);
            hero.ShowEQ();
            hero.Unequip(miecz);
            hero.GetItem(miecz2);
            hero.ShowEQ();
        }
    }
}