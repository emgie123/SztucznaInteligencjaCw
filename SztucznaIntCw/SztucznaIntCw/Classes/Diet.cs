
using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;

namespace SztucznaIntCw.Classes
{
    public class Diet
    {

        public List<IProduct> _choosenProducts; 

        public Dictionary<int, IMeal> Meals { get; set; }

   
    }
}
