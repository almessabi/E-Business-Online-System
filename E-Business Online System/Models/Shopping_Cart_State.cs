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
    
    public partial class Shopping_Cart_State
    {
        public Shopping_Cart_State()
        {
            this.Shopping_Cart = new HashSet<Shopping_Cart>();
        }
    
        public int Cart_State_ID { get; set; }
        public string Cart_State_Description { get; set; }
    
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}