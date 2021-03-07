using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaristaApi;
using System;

namespace BaristaApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        //**************************
        //CHECK INSTANCE
        //**************************
        [TestMethod]
        //Checking parent
        public void InstanceTest()
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

            Assert.IsInstanceOfType(cappuccino, typeof(Espresso));
        }

        [TestMethod]
        //Checking child
        public void InstanceTest2()
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
            
            //If you change typeof below to Macchiato, test will fail.
            Assert.IsInstanceOfType(cappuccino, typeof(Capuccino));
        }

        //**************************
        //CHECK CUP TYPE
        //**************************
        [TestMethod]
        public void CupTypeSmall()
        {
            var cupType = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Latte)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(CupTypes.CupType.Small, cupType.CupSize);
        }

        [TestMethod]
        public void CupTypeMedium()
        {
            var cupType = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Latte)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(CupTypes.CupType.Medium, cupType.CupSize);
        }

        [TestMethod]
        public void CupTypeLarge()
        {
            var cupType = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Latte)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(CupTypes.CupType.Large, cupType.CupSize);
        }

        [TestMethod]
        public void CupTypeFalse()
        {
            var cupTypeFail = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Latte)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.IsFalse(CupTypes.CupType.Medium == cupTypeFail.CupSize);
        }

        //**************************
        //CHECK BEAN TYPE
        //**************************
        [TestMethod]
        public void BeanTypeArabica()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Macchiato)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(BeanTypes.BeanType.Arabica, bean.Bean);
        }

        [TestMethod]
        public void BeanTypeRobusta()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Macchiato)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(BeanTypes.BeanType.Robusta, bean.Bean);
        }

        [TestMethod]
        public void BeanTypeFalse()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Macchiato)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Arabica)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.IsFalse(BeanTypes.BeanType.Robusta == bean.Bean);
        }

        //**************************
        //CHECK BEAN AMOUNT. Below is the expected value
        //Small: 4
        //Medium: 6
        //Large: 8
        //**************************
        [TestMethod]
        public void BeanAmountSmall()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Espresso)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(4, bean.BeanAmount);
        }

        [TestMethod]
        public void BeanAmountMedium()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Espresso)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(6, bean.BeanAmount);
        }

        [TestMethod]
        public void BeanAmountLarge()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Espresso)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(8, bean.BeanAmount);
        }

        [TestMethod]
        public void BeanAmountFalse()
        {
            var bean = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Espresso)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.IsFalse(100 == bean.BeanAmount);
        }

        //**************************
        //CHECK BOILED WATER. Below is the expected value
        //Small: 8
        //Medium: 12
        //Large: 16
        //**************************
        [TestMethod]
        public void BoiledWaterSmallCup()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Mocha)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(8, water.Water);
        }

        [TestMethod]
        public void BoiledWaterMediumCup()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Mocha)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(12, water.Water);
        }

        [TestMethod]
        public void BoiledWaterLargeCup()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Mocha)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(16, water.Water);
        }

        [TestMethod]
        public void BoiledWaterFail()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Mocha)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.IsFalse(12 == water.Water);
        }

        //Americano expected:
        //Small: 8 + 4
        //Medium 12 + 6
        //Large: 16 + 8
        [TestMethod]
        public void BoiledWaterSmallCupAmericano()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Americano)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(12, water.Water);
        }

        [TestMethod]
        public void BoiledWaterMediumCupAmericano()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Americano)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(18, water.Water);
        }

        [TestMethod]
        public void BoiledWaterLargeCupAmericano()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Americano)
                .SelectCup(CupTypes.CupType.Large)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(24, water.Water);
        }

        [TestMethod]
        public void BoiledWaterAmericanoFail()
        {
            var water = BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Americano)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.IsFalse(0 == water.Water);
        }

        //**************************
        //CHECK INGREDIENTS
        //**************************
        [TestMethod]
        public void CheckIngredientsCustom()
        {
            var ingredient = (Custom)BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Custom)
                .SelectCup(CupTypes.CupType.Small)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient(10, 20, 30)
                .ToBeverage();

            Assert.AreEqual(ingredient.Milk, 10);
            Assert.AreEqual(ingredient.MilkFoam, 20);
            Assert.AreEqual(ingredient.ChocolateSyrup, 30);
        }

        [TestMethod]
        public void CheckIngredientsMocha()
        {
            var ingredient = (Mocha)BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Mocha)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                .AddIngredient()
                .ToBeverage();

            Assert.AreEqual(ingredient.Milk, 24);
            Assert.AreEqual(ingredient.ChocolateSyrup, 12);
        }

        [TestMethod]
        public void CheckIngredientsMacchiato()
        {
            var ingredient = (Macchiato)BeverageBuilder.StartBrew()
                .CoffeeType(BeverageTypes.BeverageType.Macchiato)
                .SelectCup(CupTypes.CupType.Medium)
                .ChooseBeans(BeanTypes.BeanType.Robusta)
                .GrindBean()
                .BoilWater()
                //The only beverage that actually can take parameters is Custom.
                //This Assert will pass, because a Macchiato has its predefined ingredients based on cupsize.
                //Therefore our program will ignore the parameter values below.
                .AddIngredient(100, 100, 100)
                .ToBeverage();

            Assert.AreEqual(ingredient.MilkFoam, 36);
        }
    }
}
