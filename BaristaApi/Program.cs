using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Chaining with determined order.

            var firstBeverage = (Macchiato)BeverageBuilder
                .StartBrew().CoffeeType(BeverageTypes.BeverageType.Macchiato)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .ToBeverage();

            Console.WriteLine(firstBeverage.CupSize);

            //Put code below inside belonging methods
            //Console.WriteLine($"Beverage Type: {firstBeverage.Type}." +
            //    $"\nCup Size: {firstBeverage.CupSize}" +
            //    $"\nBean Type: {firstBeverage.Bean}");
        }
    } 
} 
