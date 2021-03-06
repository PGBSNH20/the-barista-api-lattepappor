using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Interface
{
    public interface IBeverageBuilderIngredient
    {
        IBeverageBuilderFinish AddIngredient(int milk = 0, int milkFoam = 0, int chocolateSyrup = 0);
    }
}
