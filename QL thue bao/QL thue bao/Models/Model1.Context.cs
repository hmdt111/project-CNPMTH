﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_thue_bao.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTHUEBAOEntities : DbContext
    {
        public QLTHUEBAOEntities()
            : base("name=QLTHUEBAOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DIENTHOAI> DIENTHOAIs { get; set; }
        public virtual DbSet<LOAITHUEBAO> LOAITHUEBAOs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THETRATRUOC> THETRATRUOCs { get; set; }
        public virtual DbSet<THUEBAO> THUEBAOs { get; set; }
        public virtual DbSet<TRASAU> TRASAUs { get; set; }
    }
}
