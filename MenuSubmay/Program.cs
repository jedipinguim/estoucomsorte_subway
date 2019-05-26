using System;

namespace MenuSubmay
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(menu.GetMenuItem()); 
            }

        }
    }
}
