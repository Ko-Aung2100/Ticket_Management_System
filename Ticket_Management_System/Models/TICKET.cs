//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ticket_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TICKET
    {
        public int ID { get; set; }
        public Nullable<int> TID { get; set; }
        public Nullable<int> DID { get; set; }
        public Nullable<decimal> COST { get; set; }
        public string FROM { get; set; }
        public Nullable<System.DateTime> TIME { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual DESTINATION DESTINATION { get; set; }
        public virtual TERMINAL TERMINAL { get; set; }
    }
}
