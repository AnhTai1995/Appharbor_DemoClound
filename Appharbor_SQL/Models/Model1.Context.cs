﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appharbor_SQL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db1a5b901da9be49abba78a6cc002d7f1aEntities : DbContext
    {
        public db1a5b901da9be49abba78a6cc002d7f1aEntities()
            : base("name=db1a5b901da9be49abba78a6cc002d7f1aEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hocsinh> Hocsinhs { get; set; }
    }
}