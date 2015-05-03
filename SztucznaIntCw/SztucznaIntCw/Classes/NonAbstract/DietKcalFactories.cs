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

        public static Dictionary<int, Dictionary<int, Func<decimal, decimal>>> PercentagePerMeal = new Dictionary<int, Dictionary<int, Func<decimal, decimal>>>
        {
            {3,new Dictionary<int, Func<decimal, decimal>>
                {
                    {0,(dailyGrams)=>(dailyGrams*35)/100},
                    {1,(dailyGrams)=>(dailyGrams*40)/100},
                    {2,(dailyGrams)=>(dailyGrams*25)/100}
                }
           },

            {
                4,new Dictionary<int, Func<decimal, decimal>>
                {
                    {0,(dailyGrams)=>(dailyGrams*30)/100},
                    {1,(dailyGrams)=>(dailyGrams*20)/100},
                    {2,(dailyGrams)=>(dailyGrams*30)/100},
                    {3,(dailyGrams)=>(dailyGrams*20)/100}
                }
            },
            {
                5, new Dictionary<int, Func<decimal, decimal>>
                {
                   {0,(dailyGrams)=>(dailyGrams*25)/100},
                   {1,(dailyGrams)=>(dailyGrams*15)/100},
                   {2,(dailyGrams)=>(dailyGrams*30)/100},
                   {3,(dailyGrams)=>(dailyGrams*20)/100},
                   {4,(dailyGrams)=>(dailyGrams*15)/100} 
                }
            
            }



        };
  
        public static Dictionary<TypeOfDiet, Dictionary<TypeOfPhysique,Func<int,decimal,MacroElements>>> MacroElementsDependingOnDietType = new Dictionary<TypeOfDiet, Dictionary<TypeOfPhysique, Func<int, decimal, MacroElements>>>
        {
            {TypeOfDiet.ToMaintainWeight, new Dictionary<TypeOfPhysique, Func<int,decimal,MacroElements>>
                                            {
                                               { TypeOfPhysique.Ekto, (TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                   {
                                                       Proteins = ((TDEEWitchDietTypeKcalIncluded*15)/100)/4,
                                                       Fats = ((TDEEWitchDietTypeKcalIncluded*25)/100)/9,
                                                       Carbohydrates = ((TDEEWitchDietTypeKcalIncluded*60)/100)/4,
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                         Proteins = ((TDEEWitchDietTypeKcalIncluded*17)/100)/4,
                                                   Fats = ((TDEEWitchDietTypeKcalIncluded*28)/100)/9,
                                                   Carbohydrates = ((TDEEWitchDietTypeKcalIncluded*55)/100)/4,
                                                    }
    
                                                },
                                               
                                                { TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                         Proteins = ((TDEEWitchDietTypeKcalIncluded*23)/100)/4,
                                                       Fats = ((TDEEWitchDietTypeKcalIncluded*32)/100)/9,
                                                       Carbohydrates = ((TDEEWitchDietTypeKcalIncluded*45)/100)/4,
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
                                                       Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.1m*4)-(weight*9))/4,
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.3m,
                                                        Fats = weight*1.2m,
                                                        Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.3m*4)-(weight*1.2m*9))/4,
                                                    }
    
                                                },
                                               
                                                { 
                                                    TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.5m,
                                                        Fats = weight*1.3m,
                                                        Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.5m*4)-(weight*1.3m*9))/4,
                                                    }


                                                }   
                                               
                                            }
            },

            
            {TypeOfDiet.ToLoseWeight, new Dictionary<TypeOfPhysique, Func<int,decimal,MacroElements>>
                                            {
                                               { TypeOfPhysique.Ekto, (TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                   {
                                                       Proteins = weight*2.1m,
                                                       Fats = weight*0.8m,
                                                       Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.1m*4)-(weight*0.8m*9))/4,
                                                   }
                                               },

                                                {
                                                    TypeOfPhysique.Mezo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.3m,
                                                        Fats = weight,
                                                        Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.3m*4)-(weight*9))/4,
                                                    }
    
                                                },
                                               
                                                { 
                                                    TypeOfPhysique.Endo,(TDEEWitchDietTypeKcalIncluded,weight)=> new MacroElements()
                                                    {
                                                        Proteins = weight*2.4m,
                                                        Fats = weight,
                                                        Carbohydrates = (TDEEWitchDietTypeKcalIncluded-(weight*2.4m*4)-(weight*9))/4,
                                                    }


                                                }   
                                               
                                            }
            },

            
                                  
        };



    }
}
