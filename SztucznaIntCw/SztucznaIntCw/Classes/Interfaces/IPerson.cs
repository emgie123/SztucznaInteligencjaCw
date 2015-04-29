using System.Collections.Generic;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IPerson
    {
         float Weight { get; set; }
         float Height { get; set; }
         TypeOfActivity TypeOfActivity { get; set; }
         TypeOfPhysique TypeOfPhysique { get; set; }
         float BMI { get; set; }
         Diet diet { get; set; }
         int TDEE { get; set; }

         List<IMeal> prefferedMeals { get; set; }
         List<IProduct> PrefferedProducts { get; set; }
    }
}