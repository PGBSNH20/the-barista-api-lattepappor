using System;
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
    public interface IBeverageBuilderCupType
    {
        IBeverageBuilderBeanType SelectCup(CupTypes.CupType cupType);
    }
    public interface IBeverageBuilderBeanType
    {
        IBeverageBuilderBeanGrind ChooseBeans(BeanTypes.BeanType bean);
    }
    public interface IBeverageBuilderBeanGrind
    {
        IBeverageBuilderBoilWater GrindBean();
    }
    public interface IBeverageBuilderBoilWater
    {
        IBeverageBuilderIngredient BoilWater();
    }
    public interface IBeverageBuilderIngredient
    {
        IBeverageBuilderFinish AddIngredient(int milk = 0, int milkFoam = 0, int chocolateSyrup = 0);
    }
    public interface IBeverageBuilderFinish
    {
        Espresso ToBeverage();
    }
}
