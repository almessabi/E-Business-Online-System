//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Business_Online_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dimension_Unit
    {
        public Dimension_Unit()
        {
            this.Product_Dimension = new HashSet<Product_Dimension>();
        }
    
        public int Unit_ID { get; set; }
        public string Unit_Name { get; set; }
    
        public virtual ICollection<Product_Dimension> Product_Dimension { get; set; }
    }
}