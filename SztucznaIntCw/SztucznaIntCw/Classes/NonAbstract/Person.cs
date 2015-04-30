using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Enums.Food;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Person : IPerson
    {

        public Person()
        {
            PrefferedProducts = new List<IProduct>();
        }
        //...
        public float Weight { get; set; }

        public float Height { get; set; }

        public TypeOfGender Gender { get; set; }

        public TypeOfActivity TypeOfActivity { get; set; }

        public TypeOfPhysique TypeOfPhysique { get; set; }

        public int Age { get; set; }

        public decimal BMI { get; set; }

        public Diet diet { get; set; }

        public int TDEE { get; set; }

        public List<IMeal> prefferedMeals { get; set; }

        public List<IProduct> PrefferedProducts { get; set; }
    }
}
