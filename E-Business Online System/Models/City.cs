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
    
    public partial class City
    {
        public City()
        {
            this.Addresses = new HashSet<Address>();
        }
    
        public int City_ID { get; set; }
        public string City_Name { get; set; }
        public Nullable<int> State_Or_Provence_ID { get; set; }
        public int Country_ID { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual Country Country { get; set; }
        public virtual State_Or_Provence State_Or_Provence { get; set; }
    }
}
