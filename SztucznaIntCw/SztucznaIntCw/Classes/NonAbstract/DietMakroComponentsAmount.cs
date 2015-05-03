using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class DietMakroComponentsAmount
    {

        protected IPerson Person;
        public  DietMakroComponentsAmount(IPerson person)
        {
            this.Person = person;


        }
        public Dictionary<int, IMeal> GetMealsDictionary()
        {
            var amountOfMacroelements = DietKcalFactories.MacroElementsDependingOnDietType[Person.diet.TypeofDiet][Person.TypeOfPhysique](
                 Person.TDEEWithDietTypeIncluded, Person.Weight);

            List<decimal> listOfMacroElements = new List<decimal>()
            {
                amountOfMacroelements.Proteins,
                amountOfMacroelements.Fats,
                amountOfMacroelements.Carbohydrates
            };

            Dictionary<int, IMeal> MealsDictionary = new Dictionary<int, IMeal>();

            var amountOfMeals = Person.diet.AmountOfMeals;
            for (int j = 0; j < Person.diet.AmountOfMeals; j++)
            {
                MealsDictionary.Add(
                    j,
                    new Meal()
                    {
                        TotalGramsOfProteins = DietKcalFactories.PercentagePerMeal[amountOfMeals][j](listOfMacroElements[0]),
                        TotalGramsOfFats = DietKcalFactories.PercentagePerMeal[amountOfMeals][j](listOfMacroElements[1]),
                        TotalGramsOfCarbs = DietKcalFactories.PercentagePerMeal[amountOfMeals][j](listOfMacroElements[2])

                    }
                    );
            }


            return MealsDictionary;
        }

    }
}
