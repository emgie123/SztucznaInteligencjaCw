using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Meal : IMeal
    {
        public int TotalGramsOfProteins { get; set; }
        public int TotalGramsOfFats { get; set; }
        public int TotalGramsOfCarbs { get; set; }

        public List<IProduct> ProductList { get;  set; }
        //public List<IProduct> ProductList { get;  set; }
        public Dictionary<IProduct, float> MealProducts { get; set; }

        public Meal()
        {
            ProductList = new List<IProduct>();
            //ProductList = new List<IProduct>();
            MealProducts = new Dictionary<IProduct, float>();
        }

        





    }
}
