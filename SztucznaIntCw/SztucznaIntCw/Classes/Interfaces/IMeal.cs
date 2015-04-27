using System.Collections.Generic;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IMeal
    {
        List<IProduct> ProductList { get; }
    }
}