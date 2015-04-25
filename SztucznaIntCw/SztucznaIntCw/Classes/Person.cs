using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes
{
    public class Person
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public TypeOfActivity TypeOfActivity { get; set; }
        public TypeOfPhysique TypeOfPhysique { get; set; }
        public float BMI { get; set; }
        public Diet diet { get; set; }
        public float TDEE { get; set; }

        public List<Meats> prefferedMeats { get; set; }
        //...
    }
}
