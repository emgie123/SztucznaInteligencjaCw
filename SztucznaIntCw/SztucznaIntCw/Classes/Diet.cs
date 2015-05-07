
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.Enums;
using MatrixCalculator;

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
                int proteinCounter = 0, carbCounter = 0, fatCounter = 0;
                bool correctMeal = true;
                getMacroElementForCurrentMeal(MainSourceOf.Protein, meal.Key, _proteinProducts);
                getMacroElementForCurrentMeal(MainSourceOf.Carbs, meal.Key, _carbsProducts);
                getMacroElementForCurrentMeal(MainSourceOf.Fat, meal.Key, _fatProducts);

                //composeMeal(_proteinProducts, meal.Value);
                //composeMeal(_carbsProducts, meal.Value);
                //composeMeal(_fatProducts, meal.Value);
                //getMeal(meal.Value, _proteinProducts, _carbsProducts, _fatProducts);

                int i = 0, j = 0, k = 0;
                int errorCode = getMeal(meal.Value, _proteinProducts[i], _carbsProducts[j], _fatProducts[k]);
                while (errorCode != 0)
                {
                    switch (errorCode)
                    {
                        case 1:
                        {
                            j++;
                            break;
                        }
                        case 2:
                        {
                            k++;
                            break;
                        }
                        case 3:
                        {
                            i++;
                            break;
                        }
                    }
                    if (i >= _proteinProducts.Count || j >= _carbsProducts.Count || k >= _fatProducts.Count)
                    {
                        break;
                    }
                    errorCode = getMeal(meal.Value, _proteinProducts[i], _carbsProducts[j], _fatProducts[k]);
                }
                foreach (var product in meal.Value.MealProducts.Keys)
                {
                    ChoosenProducts.Remove(product);
                }
            }
            
            
        }

        private int getMeal(IMeal meal, IProduct protProduct, IProduct carbProduct, IProduct fatProduct)
        {

            float[,] macroElements = new float[3,3];
            macroElements[0, 0] = (float) protProduct.Protein;
            macroElements[0, 1] = (float)carbProduct.Protein;
            macroElements[0, 2] = (float)fatProduct.Protein;

            macroElements[1, 0] = (float) protProduct.Carbs;
            macroElements[1, 1] = (float)carbProduct.Carbs;
            macroElements[1, 2] = (float) fatProduct.Carbs;

            macroElements[2, 0] = (float) protProduct.Fat;
            macroElements[2, 1] = (float)carbProduct.Fat;
            macroElements[2, 2] = (float) fatProduct.Fat;

            D2Matrix constValues = new D2Matrix(macroElements);

            float[] macroElementsTotal = new float[]
            {
                (float)meal.TotalGramsOfProteins,
                (float)meal.TotalGramsOfCarbs,
                (float)meal.TotalGramsOfFats
            };

            float matrixDet = constValues.GetDeterminantSquareMatrix();
            macroElements = constValues.GetComplementMatrix(matrixDet);
            constValues = new D2Matrix(macroElements);
            
            constValues.InverseMatrix(matrixDet);
            constValues.MatrixTransposition();

            float[] resultArray = new float[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultArray[i] += constValues[i, j]*macroElementsTotal[j];
                }
            }
            int errorCode = 0;
            if (resultArray[0] < 0 || resultArray[1] < 0 || resultArray[2] < 0)
            {

                if (protProduct.Rating <= carbProduct.Rating && protProduct.Rating <= fatProduct.Rating)
                {
                    return errorCode = 1;

                }
                else if (carbProduct.Rating <= protProduct.Rating && carbProduct.Rating <= fatProduct.Rating)
                {
                    return errorCode = 2;
                }
                else if (fatProduct.Rating <= protProduct.Rating && fatProduct.Rating <= carbProduct.Rating)
                {
                    return errorCode = 3;
                }
            }


            meal.MealProducts.Add(protProduct, (decimal)resultArray[0] * 100);
            meal.MealProducts.Add(carbProduct, (decimal)resultArray[1] * 100);
            meal.MealProducts.Add(fatProduct, (decimal)resultArray[2] * 100);

            return errorCode;
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
