using System;
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
        public int ID { get; set; }

        public int Rating { get; set; }

        public decimal Protein { get; set; }

        public decimal Carbs { get; set; }

        public decimal Fat { get; set; }

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
                Rating = 50;
                ID = product.id_product;
                Protein = (decimal)product.protein.Value;
                Carbs = (decimal)product.carbs.Value;
                Fat = (decimal)product.fat.Value;
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
