//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SztucznaIntCw.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public products()
        {
            this.meals = new HashSet<meals>();
        }
    
        public int id_product { get; set; }
        public Nullable<int> id_category { get; set; }
        public string nameProduct { get; set; }
        public Nullable<float> protein { get; set; }
        public Nullable<float> fat { get; set; }
        public Nullable<float> carbs { get; set; }
        public Nullable<int> kcal { get; set; }
    
        public virtual categories categories { get; set; }
        public virtual ICollection<meals> meals { get; set; }
    }
}