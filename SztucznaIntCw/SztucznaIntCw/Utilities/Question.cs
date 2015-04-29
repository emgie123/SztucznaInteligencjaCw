using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.DBModel;

namespace SztucznaIntCw.Utilities
{
    public class Question
    {
        private const string questionTemplate =
            "Proszę przypisz każdemu z poniższych produktów przynależnych do kategorii: {0}, odpowiednią wartość liczbową." +
            " Wartość ta będzie definiowała, jak bardzo lubisz spożywać dany produkt." +
            "Wartość 100 oznacza, że go uwielbiasz, zaś wartość 0 oznacza, że go nie znosisz." +
            " Domyślnie każdy produkt ma wartość 50, co oznacza poziom neutralny." + 
            "UWAGA: PLAN ŻYWIENIOWY ZOSTANIE WYGENEROWANY NA PODSTAWIE ZDEFINIOWANYCH PREFERENCJI.";

        public int Number { get; protected set; }
        public string Content { get; protected set; }
        public List<Product> Products { get; protected set; }

        public Question() { }

        public Question(int number, string category, List<products> products)
        {
            Products = new List<Product>();
            
            foreach (var product in products)
            {
                Products.Add(new Product(product) {CategoryName = category});
            }

            Content = string.Format(questionTemplate, category.ToUpper());
            Number = number;
        }

    }
}
