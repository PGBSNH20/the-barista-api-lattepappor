using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBeverage = BeverageBuilder
                .StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Custom)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient(milk: 50)
                .ToBeverage();

            Console.WriteLine(firstBeverage);
        }
    } 
} 
