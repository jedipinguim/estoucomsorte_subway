using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSubmay
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Carnes = { "Carne", "Frango", "Atum" };
        string[] Condimentos = { "Mostarda", "Mostarda Com Mel", "Pimenta Calabresa" };
        string[] Paes = { "Branco", "Integral", "Italiano" };

        public string GetMenuItem()
        {
            string randomCarnes = Carnes[Randomizer.Next(Carnes.Length)];
            string randomCondimentos = Condimentos[Randomizer.Next(Condimentos.Length)];
            string randomPaes = Paes[Randomizer.Next(Paes.Length)];

            return randomCarnes + " com " + randomCondimentos + " no " + randomPaes;
        }
    }
}
