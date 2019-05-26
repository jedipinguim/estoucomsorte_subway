using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSubmay
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Carnes = { "Carne", "Pepperoni", "Frango", "Atum", "Frango Defumado com Cream Cheese", "Frango Empanado", "Frango Teriyaki" };
        string[] Condimentos = { "Mostarda", "Molho Parmesão", "Cebola Agridoce", "Maionese", "Chipotle", "Barbecue" };
        string[] Queijos = { "Cheddar", "Prato", "Suíço" };
        string[] Vegetais = { "Alface Picada", "Tomates", "Azeitonas Pretas", "Picles", "Pimentões Verdes Crocantes", "Cebolas Fatiadas", "Pepino" };
        string[] Paes = { "9 grãos", "9 grãos com aveia e mel", "Italiano", "Três queijos", "Parmesão e Orégano" };

        public string GetMenuItem()
        {
            string randomCarnes = Carnes[Randomizer.Next(Carnes.Length)];
            string randomCondimentos = Condimentos[Randomizer.Next(Condimentos.Length)];
            string randomQueijos = Queijos[Randomizer.Next(Queijos.Length)];
            string randomVegetais = Vegetais[Randomizer.Next(Vegetais.Length)];
            string randomPaes = Paes[Randomizer.Next(Paes.Length)];

            string escolha = $"{randomCarnes} com queijo {randomQueijos}, {randomVegetais} e {randomCondimentos} no pão {randomPaes}";
            return escolha;
        }
    }
}
