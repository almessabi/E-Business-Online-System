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
    
    public partial class Customer_Review
    {
        public long Rev_ID { get; set; }
        public Nullable<int> Rev_rate { get; set; }
        public string Rev_Subject { get; set; }
        public string Rev_Description { get; set; }
        public long Product_ID { get; set; }
        public long Customer_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product_Specification Product_Specification { get; set; }
    }
}
