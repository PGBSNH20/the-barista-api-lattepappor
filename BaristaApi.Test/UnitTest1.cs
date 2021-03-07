using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaristaApi;
using System;

namespace BaristaApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cappuccino = BeverageBuilder.
                StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Cappuccino)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Type type = cappuccino.GetType();

            Assert.IsInstanceOfType(cappuccino, typeof(Espresso));
        }
    }
}
