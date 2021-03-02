using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct drinks
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBeverage();
            Latte latte = new Latte();
            Cappucino cappucino = new Cappucino();
            Americano americano = new Americano();
            Macchiato macchiato = new Macchiato();
            Mocha mocha = new Mocha();

            // Wrong amount of ingredients
            Espresso espresso1 = new Espresso();
            Latte latte1 = new Latte();
            Cappucino cappucino1 = new Cappucino();
            Americano americano1 = new Americano();
            Macchiato macchiato1 = new Macchiato();
            Mocha mocha1 = new Mocha();

            // Mixed ingredients (ex: create new Espresso with Latte ingredients)
            Latte latte2 = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBeverage();
            Espresso espresso2 = new Espresso();
            Cappucino cappucino2 = new Cappucino();
            Americano americano2 = new Americano();
            Macchiato macchiato2 = new Macchiato();
            Mocha mocha2 = new Mocha();
        }
    } 
} 
