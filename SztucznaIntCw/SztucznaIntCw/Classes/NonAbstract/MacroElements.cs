
using System;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class MacroElements
    {

        public decimal Proteins { get; set; }
        public decimal Fats { get; set; }
        public decimal Carbohydrates { get; set; }

        public void CalculateAndSetCarbohydratesMultiplier(int restOfKcal,int weight)
        {
            Carbohydrates = (restOfKcal/4)/weight;
        }
    }
}
