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
    
    public partial class Order_State
    {
        public Order_State()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Ord_State_ID { get; set; }
        public string Oder_State_Description { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}