using System.Collections.Generic;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IPerson
    {
         decimal Weight { get; set; }
         decimal Height { get; set; }
         TypeOfGender Gender { get; set; }
         TypeOfPhysique TypeOfPhysique { get; set; }
         int Age { get; set; }
         decimal BMI { get; set; }
         Diet diet { get; set; }
         int CalculatedTDEE { get; set; }
         int TDEEKcalChange { get; set; }
         int TDEEWithDietTypeIncluded { get; set; }
        

         
         int WeeklyStrenghtActivity { get; set; }
         int WeeklyAeroActivity { get; set; }

    
    }
}