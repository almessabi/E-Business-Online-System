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
    
    public partial class Customer_Credit_Cards
    {
        public Customer_Credit_Cards()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public long Cust_Credit_ID { get; set; }
        public string Cust_Credit_Card_No { get; set; }
        public string Cust_Card_Expiration_Date { get; set; }
        public string Cust_Card_Holder_Name { get; set; }
        public string Cust_Card_Security_Value { get; set; }
        public long Cust_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
