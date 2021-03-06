using System;
using System.Collections.Generic;
using System.Text;

namespace BaristaApi
{
    public class Espresso
    {
        public BeverageTypes.BeverageType Type;
        public BeanTypes.BeanType Bean;
        public CupTypes.CupType CupSize;
        public bool IsGrinded;
        public int BeanAmount;
        public int Water;
        public int BrewTemp;

        public Espresso()
        {

        }
        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\n";
        }
    }

    public class Capuccino : Espresso
    {
        public int Milk;
        public int MilkFoam;

        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\nMilk: {Milk}cl\nMilkfoam: {MilkFoam}cl\n";
        }
    }

    public class Americano : Espresso
    {
        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\n";
        }
    }

    public class Macchiato : Espresso
    {
        public int MilkFoam;

        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\nMilkfoam: {MilkFoam}cl\n";
        }
    }

    public class Mocha : Espresso
    {
        public int ChocolateSyrup;
        public int Milk;

        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\nMilk: {Milk}cl\nChocolate Syrup: {ChocolateSyrup}g\n";
        }
    }

    public class Latte : Espresso
    {
        public int Milk;
        public override string ToString()
        {
            return $"Summary\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}\nMilk: {Milk}cl\n";
        }
    }

    public class Custom : Espresso
    {
        public int Milk;
        public int MilkFoam;
        public int ChocolateSyrup;

        public override string ToString()
        {
            string milk = Milk > 0 ? $"\nMilk: {Milk}cl" : "";
            string milkFoam = MilkFoam > 0 ? $"\nMilk foam: {MilkFoam}cl" : "";
            string chocolateSyrup = ChocolateSyrup > 0 ? $"\nChocolate syrup: {ChocolateSyrup}g" : "";

            return $"### Beverage Summary ###\n\nBeverage: {Type}\nEspresso: {Water}cl\nBean type: {Bean}{milk}{milkFoam}{chocolateSyrup}\n";
        }
    }
}

