﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EbusinessEntities : DbContext
    {
        public EbusinessEntities()
            : base("name=EbusinessEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer_Claim> Customer_Claim { get; set; }
        public DbSet<Customer_Credit_Cards> Customer_Credit_Cards { get; set; }
        public DbSet<Customer_Review> Customer_Review { get; set; }
        public DbSet<Customer_State> Customer_State { get; set; }
        public DbSet<Dimension_Unit> Dimension_Unit { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Line_Item> Order_Line_Item { get; set; }
        public DbSet<Order_State> Order_State { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product_By_Supplier> Product_By_Supplier { get; set; }
        public DbSet<Product_Dimension> Product_Dimension { get; set; }
        public DbSet<Product_Item> Product_Item { get; set; }
        public DbSet<Product_Item_State> Product_Item_State { get; set; }
        public DbSet<Product_Specification> Product_Specification { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Shipment_Service_Type> Shipment_Service_Type { get; set; }
        public DbSet<Shopping_Cart> Shopping_Cart { get; set; }
        public DbSet<Shopping_Cart_Items> Shopping_Cart_Items { get; set; }
        public DbSet<Shopping_Cart_State> Shopping_Cart_State { get; set; }
        public DbSet<State_Or_Provence> State_Or_Provence { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supplier_Contact_Preson> Supplier_Contact_Preson { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
    }
}