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
    
    public partial class State_Or_Provence
    {
        public State_Or_Provence()
        {
            this.Addresses = new HashSet<Address>();
            this.Cities = new HashSet<City>();
        }
    
        public int SoP_ID { get; set; }
        public string SoP_Name { get; set; }
        public string SoP_Code { get; set; }
        public int Country_ID { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual Country Country { get; set; }
    }
}
