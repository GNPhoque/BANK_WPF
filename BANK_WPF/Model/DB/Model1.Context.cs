﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BANK_WPF.Model.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankAppEntities : DbContext
    {
        public BankAppEntities()
            : base("name=BankAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANQUES> BANQUES { get; set; }
        public virtual DbSet<CLIENTS> CLIENTS { get; set; }
        public virtual DbSet<COMPTE> COMPTE { get; set; }
        public virtual DbSet<OPERATIONS> OPERATIONS { get; set; }
        public virtual DbSet<TYPECOMPTE> TYPECOMPTE { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}