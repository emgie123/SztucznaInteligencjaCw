
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

            foreach (var meal in Meals)
            {
                generateMeal(meal.Value);
            }
            
        }

        private void generateMeal(IMeal meal)
        {
            decimal weigth = 0;

            for (int i = 0; i < _proteinProducts.Count; i++)
            {
                if (_proteinProducts[i].Protein > meal.TotalGramsOfProteins)
                {
                    continue;
                }
                if (i == _proteinProducts.Count - 1)
                {
                    weigth = (meal.TotalGramsOfProteins * 100) / _proteinProducts[i].Protein;
                    meal.MealProducts.Add(_proteinProducts[i], weigth);
                    _proteinProducts.RemoveAt(i);
                    continue;
                }
                weigth = (meal.TotalGramsOfProteins * 100) / _proteinProducts[i].Protein;

                meal.MealProducts.Add(_proteinProducts[i], weigth);
                _proteinProducts.RemoveAt(i);
                break;
            }

            for (int i = 0; i < _carbsProducts.Count; i++)
            {
                if (_carbsProducts[i].Carbs > meal.TotalGramsOfCarbs)
                {
                    continue;
                }
                if (i == _proteinProducts.Count - 1)
                {
                    weigth = (meal.TotalGramsOfCarbs * 100) / _carbsProducts[i].Carbs;
                    meal.MealProducts.Add(_carbsProducts[i], weigth);
                    _carbsProducts.RemoveAt(i);
                    break;
                }
                weigth = (meal.TotalGramsOfCarbs * 100) / _carbsProducts[i].Carbs;

                meal.MealProducts.Add(_carbsProducts[i], weigth);
                _carbsProducts.RemoveAt(i);
                break;
            }

            for (int i = 0; i < _fatProducts.Count; i++)
            {
                if (_fatProducts[i].Fat > meal.TotalGramsOfFats)
                {
                    continue;
                }
                if (i == _proteinProducts.Count - 1)
                {
                    weigth = (meal.TotalGramsOfFats * 100) / _fatProducts[i].Fat;

                    meal.MealProducts.Add(_fatProducts[i], weigth);
                    _fatProducts.RemoveAt(i);
                    break;
                }
                weigth = (meal.TotalGramsOfFats * 100) / _fatProducts[i].Fat;

                meal.MealProducts.Add(_fatProducts[i], weigth);
                _fatProducts.RemoveAt(i);
                break;
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
