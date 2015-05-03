using System.Collections.Generic;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IMeal
    {

        decimal TotalGramsOfProteins { get; set; }
        decimal TotalGramsOfFats { get; set; }
        decimal TotalGramsOfCarbs { get; set; }

        //List<IProduct> ProductList { get; }
        Dictionary<IProduct, decimal> MealProducts { get; }
    }
}