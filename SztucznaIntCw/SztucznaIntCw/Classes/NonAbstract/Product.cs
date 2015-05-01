﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.DBModel;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract
{
    public class Product : IProduct
    {

        public int Rating { get; set; }

        public float Protein { get; set; }

        public float Carbs { get; set; }

        public float Fat { get; set; }

        public float Kcal { get; set; }

        public string CategoryName { get; set; }

        public string Name { get; set; }

        public bool IncludeInDiet { get; set; }

        public MainSourceOf MacroElement { get; set; }

        public bool[] ConsumptionTime { get; set; }

        public Product() { ConsumptionTime = new bool[5]; }

        public Product(products product)
        {
            ConsumptionTime = new bool[5];
            try
            {
                Protein = product.protein.Value;
                Carbs = product.carbs.Value;
                Fat = product.fat.Value;
                Kcal = product.kcal.Value;
                Name = product.name_product;
                MacroElement = (Fat > Protein && Fat > Carbs)
                    ? MainSourceOf.Fat
                    : (Carbs > Fat && Carbs > Protein)
                        ? MainSourceOf.Carbs
                        : (Protein > Fat && Protein > Carbs) ? MainSourceOf.Protein : MainSourceOf.Everything;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Jedno z przekazanych pól tabeli przechowuje wartość null: {0}", ex);
            }
        }



    }
}
