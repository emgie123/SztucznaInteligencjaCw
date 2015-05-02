
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.Abstract
{
    public abstract class DietMakroComponentsAmount
    {
        protected delegate Dictionary<int, IMeal> MealsDictionaryDeleagteType();
        protected MealsDictionaryDeleagteType MealsDictionaryDelegate;
        
        public TypeOfDiet TypeOfDiet;
        public int AmountOfMeals;
      
        public bool ProteinPerKg;
        public bool FatPerKg;
        public bool CarbsPerKg;

        protected DietMakroComponentsAmount(TypeOfDiet typeofDiet,int amountOfMeals)
        {
            this.TypeOfDiet = typeofDiet;
            this.AmountOfMeals = amountOfMeals;

            //możliwe że musi być poziom niżej
            switch (amountOfMeals)
            {
                case 3:
                    {
                        MealsDictionaryDelegate += ThreeMeals;
                        break;
                    }

                case 4:
                    {
                        MealsDictionaryDelegate += FourMeals;
                        break;
                    }

                case 5:
                    {
                        MealsDictionaryDelegate += FiveMeals;
                        break;
                    }
            }

        }

        protected abstract Dictionary<int, IMeal> ThreeMeals();
        protected abstract Dictionary<int, IMeal> FourMeals();
        protected abstract Dictionary<int, IMeal> FiveMeals();


        public Dictionary<int, IMeal> GetMealsDictionary()
        {
            return MealsDictionaryDelegate.Invoke();
        }

    }
}
