﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ticket_management_systemEntities1 : DbContext
    {
        public ticket_management_systemEntities1()
            : base("name=ticket_management_systemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DESTINATION> DESTINATIONS { get; set; }
        public virtual DbSet<TERMINAL> TERMINALS { get; set; }
        public virtual DbSet<TICKET> TICKETS { get; set; }
        public virtual DbSet<vw_TicketDetails> vw_TicketDetails { get; set; }
    }
}
