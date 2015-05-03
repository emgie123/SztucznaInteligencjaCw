using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Meal : IMeal
    {
        public decimal TotalGramsOfProteins { get; set; }
        public decimal TotalGramsOfFats { get; set; }
        public decimal TotalGramsOfCarbs { get; set; }

        //public List<IProduct> ProductList { get;  set; }
        public Dictionary<IProduct, decimal> MealProducts { get; set; }

        public Meal()
        {
            //ProductList = new List<IProduct>();
            MealProducts = new Dictionary<IProduct, decimal>();
        }






    }
}
