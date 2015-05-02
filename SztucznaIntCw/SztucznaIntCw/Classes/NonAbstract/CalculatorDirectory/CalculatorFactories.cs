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

        public static Dictionary<TypeOfPhysique, Func<int,int, int>> TeaStrenghtActivityFactory = new Dictionary
            <TypeOfPhysique, Func<int,int, int>>()
        {
            {TypeOfPhysique.Ekto, (activityTime,BMR) => (activityTime*9) + (7*BMR/100)},
            {TypeOfPhysique.Mezo, (activityTime,BMR) => (activityTime*8) + (int)(5.5*BMR/100)},
            {TypeOfPhysique.Endo, (activityTime,BMR) => (activityTime*7) + (4*BMR/100)},
        };


        public static Dictionary<TypeOfPhysique, Func<int, int>> TeaAeroActivityFactory = new Dictionary
          <TypeOfPhysique, Func<int, int>>()
        {
            {TypeOfPhysique.Ekto, (activityTime) => activityTime*10 + 160},
            {TypeOfPhysique.Mezo, (activityTime) => (int)(activityTime*7.5 + 120)},
            {TypeOfPhysique.Endo, (activityTime) => activityTime*5 + 60},
        };


        public static Dictionary<TypeOfPhysique, Func<int>> NEATValueFactory = new Dictionary
       <TypeOfPhysique, Func<int>>()
        {
            {TypeOfPhysique.Ekto, () => 300},
            {TypeOfPhysique.Mezo, () => 240},
            {TypeOfPhysique.Endo, () => 160}
        };

        public static Dictionary<TypeOfPhysique, Func<int,int>> TEFValueFactory = new Dictionary
        <TypeOfPhysique, Func<int,int>>()
        {
            {TypeOfPhysique.Ekto, (TDEE) => TDEE*10/100},
            {TypeOfPhysique.Mezo, (TDEE) => TDEE*8/100},
            {TypeOfPhysique.Endo, (TDEE) => TDEE*6/100}
        };


    }
}
