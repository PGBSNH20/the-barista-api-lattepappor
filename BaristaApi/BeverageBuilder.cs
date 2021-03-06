﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using BaristaApi.Interface;

namespace BaristaApi
{
    public class BeverageBuilder :
        IBeverageBuilderCoffeeType,
        IBeverageBuilderCupType,
        IBeverageBuilderBeanType,
        IBeverageBuilderBeanGrind,
        IBeverageBuilderBoilWater,
        IBeverageBuilderIngredient,
        IBeverageBuilderFinish
    {

        private BeverageTypes.BeverageType _type;
        private BeanTypes.BeanType _bean;
        private CupTypes.CupType _cupSize;
        private bool _isGrinded;
        private int _beanAmount;
        private int _water;
        private int _brewTemp;
        private int _milk;
        private int _milkFoam;
        private int _chocolateSyrup;

        //private BeverageBuilder()
        //{

        //}

        public static IBeverageBuilderCoffeeType StartBrew()
        {
            return new BeverageBuilder();
        }

        public IBeverageBuilderCupType CoffeeType(BeverageTypes.BeverageType type)
        {
            _type = type;
            Console.WriteLine("Select Beverage");
            Thread.Sleep(1500);
            Console.WriteLine($"You Selected: {_type}\n");
            Thread.Sleep(1500);
            return this;
        }

        public IBeverageBuilderBeanType SelectCup(CupTypes.CupType cupType)
        {
            _cupSize = cupType;
            Console.WriteLine("Select Cup Size");
            Thread.Sleep(1500);
            Console.WriteLine($"You Selected: {_cupSize}\n");
            Thread.Sleep(1500);
            return this;
        }
        public IBeverageBuilderBeanGrind ChooseBeans(BeanTypes.BeanType bean)
        {
            _bean = bean;
            Console.WriteLine("Select Bean Type");
            Thread.Sleep(1500);
            Console.WriteLine($"You Selected: {_bean}\n");
            Thread.Sleep(1500);
            return this;
        }

        public IBeverageBuilderBoilWater GrindBean()
        {
            // Implementera default case
            _beanAmount = _cupSize switch
            {
                CupTypes.CupType.Small => _beanAmount = 4,
                CupTypes.CupType.Medium => _beanAmount = 6,
                _ => _beanAmount = 8,
            };
            GrindingProcess();

            _isGrinded = true;
            return this;
        }

        public IBeverageBuilderIngredient BoilWater()
        {
            _water = _cupSize switch
            {
                CupTypes.CupType.Small => _water = 8,
                CupTypes.CupType.Medium => _water = 12,
                _ => _water = 16,
            };
            BoilingProcess();
            return this;
        }

        public IBeverageBuilderFinish AddIngredient(int milk = 0, int milkFoam = 0, int chocolateSyrup = 0)
        {
            string custom = _type == BeverageTypes.BeverageType.Custom ? "Custom Beverage" : _type.ToString();
            Console.WriteLine($"Preparing {custom}\n");
            Thread.Sleep(1000);
            Console.WriteLine("...\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Enjoy your {custom}!\n");
            Thread.Sleep(1000);

            //ESPRESSO
            //Don't need this because Espresso is the parent / base.

            switch (_type)
            {

                case BeverageTypes.BeverageType.Americano:
                    _water = _cupSize switch
                    {
                        CupTypes.CupType.Small => _water += 4,
                        CupTypes.CupType.Medium => _water += 6,
                        CupTypes.CupType.Large => _water += 8
                    };
                    break;

                case BeverageTypes.BeverageType.Cappuccino:
                    (_milk, _milkFoam) = _cupSize switch
                    {
                        CupTypes.CupType.Small => (8, 8),
                        CupTypes.CupType.Medium => (12, 12),
                        CupTypes.CupType.Large => (16, 16)
                    };
                    break;

                case BeverageTypes.BeverageType.Latte:
                    _milk = _cupSize switch
                    {
                        CupTypes.CupType.Small => _milk += 24,
                        CupTypes.CupType.Medium => _milk += 36,
                        CupTypes.CupType.Large => _milk += 48
                    };
                    break;

                case BeverageTypes.BeverageType.Macchiato:
                    _milkFoam = _cupSize switch
                    {
                        CupTypes.CupType.Small => _milkFoam += 24,
                        CupTypes.CupType.Medium => _milkFoam += 36,
                        CupTypes.CupType.Large => _milkFoam += 48
                    };
                    break;

                case BeverageTypes.BeverageType.Mocha:
                    (_milk, _chocolateSyrup) = _cupSize switch
                    {
                        CupTypes.CupType.Small => (16, 8),
                        CupTypes.CupType.Medium => (24, 12),
                        CupTypes.CupType.Large => (32, 16)
                    };
                    break;

                case BeverageTypes.BeverageType.Custom:
                    (_milk, _milkFoam, _chocolateSyrup) = _cupSize switch
                    {
                        CupTypes.CupType.Small => (milk, milkFoam, chocolateSyrup),
                        CupTypes.CupType.Medium => (milk, milkFoam, chocolateSyrup),
                        CupTypes.CupType.Large => (milk, milkFoam, chocolateSyrup)
                    };
                    break;
            }

            return this;
        }

        public Espresso ToBeverage() => _type switch
        {
            BeverageTypes.BeverageType.Americano => new Americano { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, BrewTemp = _brewTemp },

            BeverageTypes.BeverageType.Cappuccino => new Capuccino { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, Milk = _milk, MilkFoam = _milkFoam, BrewTemp = _brewTemp },

            BeverageTypes.BeverageType.Latte => new Latte { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, Milk = _milk, BrewTemp = _brewTemp },

            BeverageTypes.BeverageType.Mocha => new Mocha { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, Milk = _milk, ChocolateSyrup = _chocolateSyrup, BrewTemp = _brewTemp },

            BeverageTypes.BeverageType.Custom => new Custom { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, Milk = _milk, MilkFoam = _milkFoam, ChocolateSyrup = _chocolateSyrup, BrewTemp = _brewTemp },

            BeverageTypes.BeverageType.Macchiato => new Macchiato { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, MilkFoam = _milkFoam, BrewTemp = _brewTemp },

            _ => new Espresso { Type = _type, CupSize = _cupSize, Bean = _bean, IsGrinded = _isGrinded, BeanAmount = _beanAmount, Water = _water, BrewTemp = _brewTemp },
        };

        // ################ Print to console methods #################
        void GrindingProcess()
        {
            Console.WriteLine($"Grinding {_beanAmount} grams");
            Thread.Sleep(1000);
            Console.WriteLine("Almost done...");
            Thread.Sleep(1000);
            Console.WriteLine("Done!");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Printar Vattnets temp till console och ökar _brewTemp baserat på dryckernas ideal temperatur.
        /// </summary>
        void BoilingProcess()
        {
            int idealTemp;

            idealTemp = _type switch
            {
                BeverageTypes.BeverageType.Americano => idealTemp = 89,
                BeverageTypes.BeverageType.Cappuccino => idealTemp = 99,
                BeverageTypes.BeverageType.Latte => idealTemp = 94,
                BeverageTypes.BeverageType.Macchiato => idealTemp = 90,
                BeverageTypes.BeverageType.Mocha => idealTemp = 95,
                BeverageTypes.BeverageType.Custom => idealTemp = 92,
                _ => idealTemp = 86
            };

            Console.WriteLine("\nBoiling water...\n");

            // _brewTemp = 7 är baserat på kallt kranvattens medeltemperatur
            for (_brewTemp = 7; _brewTemp < idealTemp; _brewTemp++)
            {
                if (_brewTemp == 10 || _brewTemp == 20 || _brewTemp == 30 || _brewTemp == 40 || _brewTemp == 50 || _brewTemp == 60 || _brewTemp == 70 || _brewTemp == 80 || _brewTemp == 90 || _brewTemp == 100)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"Water Temp: {_brewTemp}");
                }
            }
            Thread.Sleep(500);
            Console.WriteLine($"Water Temp: {_brewTemp}");

            Console.WriteLine("\nBoiling completed!");
            Thread.Sleep(1000);

            Console.WriteLine($"\nPouring {_water}cl water\n");
            Thread.Sleep(1000);
        }
    }
}
