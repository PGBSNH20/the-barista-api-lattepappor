using System;
using System.Collections.Generic;
using System.Text;

namespace BaristaApi
{
    public class Espresso
    {
        // ta bort presentation av tomma med ToString override
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
    }

    public class Capuccino : Espresso
    {
        public int Milk;
        public int MilkFoam;
    }

    public class Americano : Espresso
    {

    }

    public class Macchiato : Espresso
    {
        public int MilkFoam;
    }

    public class Mocha : Espresso
    {
        public int ChocolateSyrup;
        public int Milk;
    }

    public class Latte : Espresso
    {
        public int Milk;
    }

    public class Custom : Espresso
    {
        public int Milk;
        public int MilkFoam;
        public int ChocolateSyrup;
    }
}

