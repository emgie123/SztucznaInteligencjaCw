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
    
    public partial class categories
    {
        public categories()
        {
            this.products = new HashSet<products>();
        }
    
        public int id_category { get; set; }
        public string nameCategory { get; set; }
    
        public virtual ICollection<products> products { get; set; }
    }
}
