using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Person : IPerson
    {
   
        //...
        public float Weight { get; set; }

        public float Height { get; set; }

        public TypeOfActivity TypeOfActivity { get; set; }

        public TypeOfPhysique TypeOfPhysique { get; set; }

        public float BMI { get; set; }

        public Diet diet { get; set; }

        public int TDEE { get; set; }

        public List<Meats> prefferedMeats { get; set; }
    
    }
}
