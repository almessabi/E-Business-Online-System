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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Customer_Claim = new HashSet<Customer_Claim>();
            this.Customer_Credit_Cards = new HashSet<Customer_Credit_Cards>();
            this.Customer_Review = new HashSet<Customer_Review>();
            this.Orders = new HashSet<Order>();
            this.Payments = new HashSet<Payment>();
            this.Shipments = new HashSet<Shipment>();
            this.Shopping_Cart = new HashSet<Shopping_Cart>();
        }
    
        public long Cust_Id { get; set; }
        public string Cust_FName { get; set; }
        public string Cust_LName { get; set; }
        public string Cust_email { get; set; }
        public string Cust_Cellphone { get; set; }
        public string Cust_Home_Phone { get; set; }
        public string Cust_Username { get; set; }
        public string Cust_Password { get; set; }
        public Nullable<int> Cust_Login_Status { get; set; }
        public Nullable<long> Cust_Billing_Address { get; set; }
        public Nullable<long> Cust_Shipping_Address { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual ICollection<Customer_Claim> Customer_Claim { get; set; }
        public virtual ICollection<Customer_Credit_Cards> Customer_Credit_Cards { get; set; }
        public virtual Customer_State Customer_State { get; set; }
        public virtual ICollection<Customer_Review> Customer_Review { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}
