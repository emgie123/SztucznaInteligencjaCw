using System.Collections.Generic;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IMeal
    {
       
        int GramsOfProteins { get; set; }
        int GramsOfFats { get; set; }
        int GramsOfCarbs { get; set; }

        List<IProduct> ProductList { get; }
    }
}