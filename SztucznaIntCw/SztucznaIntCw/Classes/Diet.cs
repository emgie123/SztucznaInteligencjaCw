
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes
{
    public class Diet
    {
        public Dictionary<int, IMeal> Meals { get; set; }

        public TypeOfDiet TypeofDiet;
        public int AmountOfMeals;

        public List<IProduct> ChoosenProducts = new List<IProduct>();

        private List<IProduct> _proteinProducts = new List<IProduct>();
        private List<IProduct> _carbsProducts = new List<IProduct>();
        private List<IProduct> _fatProducts = new List<IProduct>(); 

        //todo: Oprogramować logikę dotyczącą generowania planu diety (w tym celu należy na podstawie 
        // otrzymanego słownika wyciągnąć schemat danego posiłka (ile gramów danego składnika)

        public void GenerateDiet()
        {
            
            foreach (var meal in Meals)
            {
                getMacroElementForCurrentMeal(MainSourceOf.Protein, meal.Key, _proteinProducts);
                getMacroElementForCurrentMeal(MainSourceOf.Carbs, meal.Key, _carbsProducts);
                getMacroElementForCurrentMeal(MainSourceOf.Fat, meal.Key, _fatProducts);

                composeMeal(_proteinProducts, meal.Value);
                composeMeal(_carbsProducts, meal.Value);
                composeMeal(_fatProducts, meal.Value);

            }
            
            
        }

        private void getMacroElementForCurrentMeal(MainSourceOf macroElement, int mealNumber, List<IProduct> destinationList)
        {
            destinationList.Clear();
            destinationList.AddRange(ChoosenProducts.Where(choosenProduct => choosenProduct.ConsumptionTime[mealNumber] == true && 
                choosenProduct.MacroElement == macroElement));
            destinationList.Sort((x,y) => y.Rating.CompareTo(x.Rating));
        }

        private void composeMeal(List<IProduct> productsForCurrentMeal, IMeal meal)
        {
            var currentMacroElement = productsForCurrentMeal[0].MacroElement;
            int weightOfComponent = 0;
            switch (currentMacroElement)
            {
                case MainSourceOf.Protein:
                {
                    for (int i = 0; i < productsForCurrentMeal.Count; i++)
                    {
                        if (meal.TotalGramsOfProteins <= 0)
                        {
                            break;
                        }
                        weightOfComponent = (int)((meal.TotalGramsOfProteins * 100) / productsForCurrentMeal[i].Protein);
                        meal.TotalGramsOfCarbs -= (weightOfComponent * productsForCurrentMeal[i].Carbs) / 100;
                        meal.TotalGramsOfFats -= (weightOfComponent * productsForCurrentMeal[i].Fat) / 100;
                        meal.MealProducts.Add(productsForCurrentMeal[i], weightOfComponent);
                        ChoosenProducts.Remove(productsForCurrentMeal[i]);
                        break;
                    }                  
                    break;
                }
                case MainSourceOf.Carbs:
                {
                    for (int i = 0; i < productsForCurrentMeal.Count; i++)
                    {
                        if (meal.TotalGramsOfCarbs <= 0)
                        {
                            break;
                        }
                        weightOfComponent = (int)((meal.TotalGramsOfCarbs * 100) / productsForCurrentMeal[i].Carbs);
                        meal.TotalGramsOfProteins -= (weightOfComponent * productsForCurrentMeal[i].Protein) / 100;
                        meal.TotalGramsOfFats -= (weightOfComponent * productsForCurrentMeal[i].Fat) / 100;
                        meal.MealProducts.Add(productsForCurrentMeal[i], weightOfComponent);
                        ChoosenProducts.Remove(productsForCurrentMeal[i]);
                        break;
                    }
                    break;
                }
                case MainSourceOf.Fat:
                {
                    for (int i = 0; i < productsForCurrentMeal.Count; i++)
                    {
                        if (meal.TotalGramsOfFats <= 0)
                        {
                            break;
                        }
                        weightOfComponent = (int)((meal.TotalGramsOfFats * 100) / productsForCurrentMeal[i].Fat);
                        meal.TotalGramsOfCarbs -= (weightOfComponent * productsForCurrentMeal[i].Carbs) / 100;
                        meal.TotalGramsOfProteins -= (weightOfComponent * productsForCurrentMeal[i].Protein) / 100;
                        meal.MealProducts.Add(productsForCurrentMeal[i], weightOfComponent);
                        ChoosenProducts.Remove(productsForCurrentMeal[i]);
                        break;
                    }
                    break;
                }
                default:
                {
                    return;
                }
            }
        }
    }
}
