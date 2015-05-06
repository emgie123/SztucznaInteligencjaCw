using System;
using System.Collections.Generic;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public static class DietKcalFactories
    {

        public static Dictionary<TypeOfPhysique, int> IncreaseWeightAdditionalKCAL = new Dictionary<TypeOfPhysique, int>
        {
            {TypeOfPhysique.Ekto, 500},
            {TypeOfPhysique.Mezo, 400},
            {TypeOfPhysique.Endo, 300},
        };

        public static Dictionary<TypeOfPhysique, int> LooseWeightMinusKCAL = new Dictionary<TypeOfPhysique, int>
        {
            {TypeOfPhysique.Ekto, -200},
            {TypeOfPhysique.Mezo, -300},
            {TypeOfPhysique.Endo, -400},
        };

        public static Dictionary<int, Dictionary<int, Func<decimal, decimal>>> PercentagePerMeal 
            = new Dictionary<int, Dictionary<int, Func<decimal, decimal>>>
        {
            {3,new Dictionary<int, Func<decimal, decimal>>
                {
                    {0,(dailyGrams)=>(dailyGrams*0.35m)},
                    {1,(dailyGrams)=>(dailyGrams*0.40m)},
                    {2,(dailyGrams)=>(dailyGrams*0.25m)}
                }
           },

            {
                4,new Dictionary<int, Func<decimal, decimal>>
                {
                    {0,(dailyGrams)=>(dailyGrams*0.30m)},
                    {1,(dailyGrams)=>(dailyGrams*0.20m)},
                    {2,(dailyGrams)=>(dailyGrams*0.30m)},
                    {3,(dailyGrams)=>(dailyGrams*0.20m)}
                }
            },
            {
                5, new Dictionary<int, Func<decimal, decimal>>
                {
                   {0,(dailyGrams)=>(dailyGrams*0.25m)},
                   {1,(dailyGrams)=>(dailyGrams*0.15m)},
                   {2,(dailyGrams)=>(dailyGrams*0.25m)},
                   {3,(dailyGrams)=>(dailyGrams*0.20m)},
                   {4,(dailyGrams)=>(dailyGrams*0.15m)} 
                }
            
            }



        };
  
        public static Dictionary<TypeOfDiet, Dictionary<TypeOfPhysique,Func<int,decimal,MacroElements>>> MacroElementsDependingOnDietType 
            = new Dictionary<TypeOfDiet, Dictionary<TypeOfPhysique, Func<int, decimal, MacroElements>>>
        {
            {TypeOfDiet.ToMaintainWeight, new Dictionary<TypeOfPhysique, Func<int,decimal,MacroElements>>
                                            {
                                               { TypeOfPhysique.Ekto, (TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                   {
                                                       Proteins = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.15m))/4,MidpointRounding.AwayFromZero),
                                                       Fats = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.25m))/9,MidpointRounding.AwayFromZero),
                                                       Carbohydrates = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.6m))/4,MidpointRounding.AwayFromZero),
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                         Proteins = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.17m))/4,MidpointRounding.AwayFromZero),
                                                   Fats = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.28m))/9,MidpointRounding.AwayFromZero),
                                                   Carbohydrates = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.55m))/4,MidpointRounding.AwayFromZero),
                                                    }
    
                                                },
                                               
                                                { TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                         Proteins = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.23m))/4,MidpointRounding.AwayFromZero),
                                                       Fats = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.32m))/9,MidpointRounding.AwayFromZero),
                                                       Carbohydrates = Math.Round(((TDEEWitchDietTypeKcalIncluded*0.45m))/4,MidpointRounding.AwayFromZero),
                                                    }


                                                }   
                                               
                                            }
            },

            {TypeOfDiet.ToGainWeight, new Dictionary<TypeOfPhysique, Func<int,decimal,MacroElements>>
                                            {
                                               { TypeOfPhysique.Ekto, (TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                   {
                                                       Proteins = weight*2.1m,
                                                       Fats = weight,
                                                       Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.1m*4)-(weight*9))/4,MidpointRounding.AwayFromZero)
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.3m,
                                                        Fats = weight*1.2m,
                                                        Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.3m*4)-(weight*1.2m*9))/4,MidpointRounding.AwayFromZero)
                                                    }
    
                                                },
                                               
                                                { 
                                                    TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.5m,
                                                        Fats = weight*1.3m,
                                                        Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.5m*4)-(weight*1.3m*9))/4,MidpointRounding.AwayFromZero)
                                                    }


                                                }   
                                               
                                            }
            },

            
            {TypeOfDiet.ToReduceWeight, new Dictionary<TypeOfPhysique, Func<int,decimal,MacroElements>>
                                            {
                                               { TypeOfPhysique.Ekto, (TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                   {
                                                       Proteins = weight*2.1m,
                                                       Fats = weight*0.8m,
                                                       Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.1m*4)-(weight*0.8m*9))/4,MidpointRounding.AwayFromZero)
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.3m,
                                                        Fats = weight,
                                                        Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.3m*4)-(weight*9))/4,MidpointRounding.AwayFromZero)
                                                    }
    
                                                },
                                               
                                                { 
                                                    TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.4m,
                                                        Fats = weight,
                                                        Carbohydrates = Math.Round((TDEEWitchDietTypeKcalIncluded-(weight*2.4m*4)-(weight*9))/4,MidpointRounding.AwayFromZero)
                                                    }


                                                }   
                                               
                                            }
            },

            
                                  
        };



    }
}
