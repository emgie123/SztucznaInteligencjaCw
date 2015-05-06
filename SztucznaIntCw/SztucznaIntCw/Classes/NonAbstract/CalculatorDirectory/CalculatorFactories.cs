using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory
{
    public static class CalculatorFactories
    {

        public static Dictionary<TypeOfPhysique, Func<decimal, decimal, decimal>> TeaStrenghtActivityFactory = new Dictionary
            <TypeOfPhysique, Func<decimal, decimal, decimal>>()
        {
            {TypeOfPhysique.Ekto, (activityTime,BMR) => Math.Round((activityTime*9) + 0.07m*BMR,MidpointRounding.AwayFromZero)},
            {TypeOfPhysique.Mezo, (activityTime,BMR) => Math.Round((activityTime*8) + 0.055m*BMR,MidpointRounding.AwayFromZero)},
            {TypeOfPhysique.Endo, (activityTime,BMR) => Math.Round((activityTime*7) + 0.04m*BMR,MidpointRounding.AwayFromZero)},
        };


        public static Dictionary<TypeOfPhysique, Func<decimal, decimal>> TeaAeroActivityFactory = new Dictionary
          <TypeOfPhysique, Func<decimal, decimal>>()
        {
            {TypeOfPhysique.Ekto, (activityTime) => activityTime*10 + 160},
            {TypeOfPhysique.Mezo, (activityTime) => activityTime*7.5m + 120},
            {TypeOfPhysique.Endo, (activityTime) => activityTime*5 + 60},
        };


        public static Dictionary<TypeOfPhysique, Func<decimal>> NEATValueFactory = new Dictionary
       <TypeOfPhysique, Func<decimal>>()
        {
            {TypeOfPhysique.Ekto, () => 300},
            {TypeOfPhysique.Mezo, () => 240},
            {TypeOfPhysique.Endo, () => 160}
        };

        public static Dictionary<TypeOfPhysique, Func<decimal, decimal>> TEFValueFactory = new Dictionary
        <TypeOfPhysique, Func<decimal, decimal>>()
        {
            {TypeOfPhysique.Ekto, (TDEE) => TDEE*0.1m},
            {TypeOfPhysique.Mezo, (TDEE) => TDEE*0.08m},
            {TypeOfPhysique.Endo, (TDEE) => TDEE*0.06m}
        };


    }
}
