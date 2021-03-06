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
    
    public partial class Payment
    {
        public Payment()
        {
            this.Customer_Claim = new HashSet<Customer_Claim>();
        }
    
        public long Payment_Number { get; set; }
        public decimal Amount { get; set; }
        public string Authorization_Number { get; set; }
        public long Customer_ID { get; set; }
        public long Order_Number { get; set; }
        public long Shipment_ID { get; set; }
        public long Credit_Card_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Customer_Claim> Customer_Claim { get; set; }
        public virtual Customer_Credit_Cards Customer_Credit_Cards { get; set; }
        public virtual Order Order { get; set; }
    }
}
