﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVEntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbCVEntityEntities : DbContext
    {
        public dbCVEntityEntities()
            : base("name=dbCVEntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdres> tblAdres { get; set; }
        public virtual DbSet<tblÇalışmalarım> tblÇalışmalarım { get; set; }
        public virtual DbSet<tblHakkımda> tblHakkımda { get; set; }
        public virtual DbSet<tblİletişim> tblİletişim { get; set; }
        public virtual DbSet<tblYetenekler> tblYetenekler { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
    }
}
