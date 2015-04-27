using System.Collections.Generic;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Meals
{
    class AfternoonMeal : Meal
    {
        public AfternoonMeal(List<IProduct> list) : base(list)
        {
        }
    }
}
