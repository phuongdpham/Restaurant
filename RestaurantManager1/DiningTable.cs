//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManager1
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiningTable
    {
        public DiningTable()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int TableNo { get; set; }
        public string Reserved { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
