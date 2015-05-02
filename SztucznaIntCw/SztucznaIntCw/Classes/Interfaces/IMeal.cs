﻿using System.Collections.Generic;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IMeal
    {
       
        int TotalGramsOfProteins { get; set; }
        int TotalGramsOfFats { get; set; }
        int TotalGramsOfCarbs { get; set; }

        List<IProduct> ProductList { get; }
    }
}