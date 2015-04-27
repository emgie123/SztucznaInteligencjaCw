using System.Collections.Generic;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Meals
{
    class EveningMeal : Meal
    {
        public EveningMeal(List<IProduct> list) : base(list)
        {
        }
    }
}
