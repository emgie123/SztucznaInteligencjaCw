
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

            foreach (var proteinProduct in _proteinProducts)
            {
                if (proteinProduct.Protein > meal.TotalGramsOfProteins)
                {
                    continue;
                }

                weigth = (proteinProduct.Protein*meal.TotalGramsOfProteins)/100;

                meal.MealProducts.Add(proteinProduct, weigth);
                _proteinProducts.Remove(proteinProduct);
            }

            foreach (var carbsProduct in _carbsProducts)
            {
                if (carbsProduct.Carbs > meal.TotalGramsOfCarbs)
                {
                    continue;
                }

                weigth = (carbsProduct.Carbs * meal.TotalGramsOfCarbs) / 100;

                meal.MealProducts.Add(carbsProduct, weigth);
                _carbsProducts.Remove(carbsProduct);
            }

            foreach (var fatProduct in _fatProducts)
            {
                if (fatProduct.Fat > meal.TotalGramsOfFats)
                {
                    continue;
                }

                weigth = (fatProduct.Fat * meal.TotalGramsOfFats) / 100;

                meal.MealProducts.Add(fatProduct, weigth);
                _fatProducts.Remove(fatProduct);
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
