using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.Abstract
{
    public abstract class Meal : IMeal
    {
        public List<IProduct> ProductList { get; protected set; }

        protected Meal(List<IProduct> list)
        {
            ProductList = list;
        }
    }
}
