using System.Collections.Generic;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Meals
{
    class MorningMeal : Meal
    {
        public MorningMeal(List<IProduct> list) : base(list)
        {
        }
    }
}
