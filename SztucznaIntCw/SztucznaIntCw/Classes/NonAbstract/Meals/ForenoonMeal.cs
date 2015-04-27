using System.Collections.Generic;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Meals
{
    class ForenoonMeal : Meal
    {
        public ForenoonMeal(List<IProduct> list) : base(list)
        {
        }
    }
}
