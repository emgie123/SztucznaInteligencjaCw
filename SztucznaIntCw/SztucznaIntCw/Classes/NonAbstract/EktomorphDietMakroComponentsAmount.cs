using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class EktomorphDietMakroComponentsAmount : DietMakroComponentsAmount
    {
        public EktomorphDietMakroComponentsAmount(TypeOfDiet typeOfDiet,int amountOfMeals) : base (typeOfDiet,amountOfMeals)
        {

          
        }

        protected override Dictionary<int, IMeal> ThreeMeals()
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<int, IMeal> FourMeals()
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<int, IMeal> FiveMeals()
        {
            throw new NotImplementedException();
        }
    }
}
