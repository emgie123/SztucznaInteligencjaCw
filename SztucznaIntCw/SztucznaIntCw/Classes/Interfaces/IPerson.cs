using System.Collections.Generic;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IPerson
    {
         float Weight { get; set; }
         float Height { get; set; }
         TypeOfGender Gender { get; set; }
         TypeOfPhysique TypeOfPhysique { get; set; }
         int Age { get; set; }
         float BMI { get; set; }
         Diet diet { get; set; }
         int TDEE { get; set; }

         int WeeklyStrenghtActivity { get; set; }
         int WeeklyAeroActivity { get; set; }

         List<IMeal> Meals { get; set; }
         List<IProduct> PrefferedProducts { get; set; }
    }
}