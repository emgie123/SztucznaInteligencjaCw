using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Person : IPerson
    {

   
        //...
        public decimal Weight { get; set; }

        public decimal Height { get; set; }

        public TypeOfGender Gender { get; set; }

        public TypeOfActivity TypeOfActivity { get; set; }

        public TypeOfPhysique TypeOfPhysique { get; set; }

        public int Age { get; set; }

        public decimal BMI { get; set; }

        public Diet diet { get; set; }

        public int CalculatedTDEE { get; set; }
        public int TDEEWithDietTypeIncluded { get; set; }

        public int TDEEKcalChange { get; set; }
        public int WeeklyStrenghtActivity { get; set; }
        public int WeeklyAeroActivity { get; set; }
  
    }
}
