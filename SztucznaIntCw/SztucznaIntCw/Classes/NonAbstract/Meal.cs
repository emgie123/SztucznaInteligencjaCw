﻿using System.Collections.Generic;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Meal : IMeal
    {
        public int GramsOfProteins { get; set; }
        public int GramsOfFats { get; set; }
        public int GramsOfCarbs { get; set; }
        public List<IProduct> ProductList { get; protected set; }

        public Meal(List<IProduct> list)
        {
            ProductList = list;
        }
    }
}