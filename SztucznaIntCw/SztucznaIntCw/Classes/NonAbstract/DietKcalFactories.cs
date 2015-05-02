using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public static class DietKcalFactories
    {

        public static Dictionary<TypeOfPhysique, int> IncreaseWeightAdditionalKCAL = new Dictionary<TypeOfPhysique, int>
        {
            {TypeOfPhysique.Ekto, 500},
            {TypeOfPhysique.Mezo, 400},
            {TypeOfPhysique.Mezo, 300},
        };

        public static Dictionary<TypeOfPhysique, int> LooseWeightMinusKCAL = new Dictionary<TypeOfPhysique, int>
        {
            {TypeOfPhysique.Ekto, -200},
            {TypeOfPhysique.Mezo, -300},
            {TypeOfPhysique.Mezo, -400},
        };

        public static List<int> PercentageOfMealForThreeMeals = new List<int>()
        {
            35,
            40,
            25
        };

        public static List<int> PercentageOfMealForFourMeals = new List<int>()
        {
            35,
            20,
            30,
            20
        };

        public static List<int> PercentageOfMealForFiveMeals = new List<int>()
        {
            25,
            15,
            30,
            20,
            15
        };

    }
}
