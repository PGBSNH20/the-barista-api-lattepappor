using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBeverage();
            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBeverage();

             
        }
    } 
} 
