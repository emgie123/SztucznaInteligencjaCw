using System.Collections.Generic;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Meals
{
    class NoonMeal : Meal
    {
        public NoonMeal(List<IProduct> list) : base(list)
        {
        }
    }
}
