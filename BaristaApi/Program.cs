using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBeverage = BeverageBuilder
                .StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Espresso)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient(milk: 50)
                .ToBeverage();
            
            Console.WriteLine(firstBeverage.BrewTemp);
        }
    } 
} 
