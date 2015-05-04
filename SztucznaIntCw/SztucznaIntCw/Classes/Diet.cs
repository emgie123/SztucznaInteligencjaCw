
using System.Collections.Generic;
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
            splitProductsInCategories();

            generateMeal(Meals);
            
            
        }

        private void generateMeal(Dictionary<int, IMeal> meals)
        {
            //  todo zmodyfikować generowanie diety - uwzględnić, że jeśli coś jest źródłem tłuszczu to
            //  także może być źródłem białka a więc zmniejszy sie także ilość potrzebnego białka w pozostałych produktach.

            foreach (var meal in meals)
            {
                decimal weigth = 0;

                for (int i = 0; i < _proteinProducts.Count; i++)
                {
                    if (_proteinProducts[i].ConsumptionTime[meal.Key] == false)
                    {
                        continue;
                    }
                    if (i == _proteinProducts.Count - 1)
                    {
                        weigth = (meal.Value.TotalGramsOfProteins * 100) / _proteinProducts[i].Protein;
                        meal.Value.MealProducts.Add(_proteinProducts[i], weigth);
                        _proteinProducts.RemoveAt(i);
                        break;
                    }

                    if (_proteinProducts[i].Protein > meal.Value.TotalGramsOfProteins)
                    {
                        continue;
                    }

                    weigth = (meal.Value.TotalGramsOfProteins * 100) / _proteinProducts[i].Protein;

                    meal.Value.MealProducts.Add(_proteinProducts[i], weigth);
                    _proteinProducts.RemoveAt(i);
                    break;
                }

                for (int i = 0; i < _carbsProducts.Count; i++)
                {
                    if (_carbsProducts[i].ConsumptionTime[meal.Key] == false)
                    {
                        continue;
                    }
                    if (i == _carbsProducts.Count - 1)
                    {
                        weigth = (meal.Value.TotalGramsOfCarbs * 100) / _carbsProducts[i].Carbs;
                        meal.Value.MealProducts.Add(_carbsProducts[i], weigth);
                        _carbsProducts.RemoveAt(i);
                        break;
                    }

                    if (_carbsProducts[i].Carbs > meal.Value.TotalGramsOfCarbs)
                    {
                        continue;
                    }

                    weigth = (meal.Value.TotalGramsOfCarbs * 100) / _carbsProducts[i].Carbs;

                    meal.Value.MealProducts.Add(_carbsProducts[i], weigth);
                    _carbsProducts.RemoveAt(i);
                    break;
                }

                for (int i = 0; i < _fatProducts.Count; i++)
                {
                    if (_fatProducts[i].ConsumptionTime[meal.Key] == false)
                    {
                        continue;
                    }
                    if (i == _fatProducts.Count - 1)
                    {
                        weigth = (meal.Value.TotalGramsOfFats * 100) / _fatProducts[i].Fat;

                        meal.Value.MealProducts.Add(_fatProducts[i], weigth);
                        _fatProducts.RemoveAt(i);
                        break;
                    }

                    if (_fatProducts[i].Fat > meal.Value.TotalGramsOfFats)
                    {
                        continue;
                    }

                    weigth = (meal.Value.TotalGramsOfFats * 100) / _fatProducts[i].Fat;

                    meal.Value.MealProducts.Add(_fatProducts[i], weigth);
                    _fatProducts.RemoveAt(i);
                    break;
                }
            }

            
        }

        private void splitProductsInCategories()
        {
            foreach (var product in ChoosenProducts)
            {
                switch (product.MacroElement)
                {
                    case MainSourceOf.Protein:
                    {
                        _proteinProducts.Add(product);
                        break;
                    }

                    case MainSourceOf.Carbs:
                    {
                        _carbsProducts.Add(product);
                        break;
                    }
                        
                    case MainSourceOf.Fat:
                    {
                        _fatProducts.Add(product);
                        break;
                    }
                }
            }
            _proteinProducts.Sort((x,y) => y.Protein.CompareTo(x.Protein));
            _carbsProducts.Sort((x,y) => y.Carbs.CompareTo(x.Carbs));
            _fatProducts.Sort((x,y) => y.Fat.CompareTo(x.Fat));
        }

    }
}
