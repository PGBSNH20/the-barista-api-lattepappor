﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Interface
{
    public interface IBeverageBuilderCoffeeType
    {
        IBeverageBuilderCupType CoffeeType(BeverageTypes.BeverageType type);
    }
}
