﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Codice generato da un modello.
//
//    Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//    Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mymoney.web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyMoneyEntities : DbContext
    {
        public MyMoneyEntities()
            : base("name=MyMoneyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AddebitoTransazioni> AddebitoTransazioni { get; set; }
        public DbSet<Conti> Conti { get; set; }
        public DbSet<TipoTransazioni> TipoTransazioni { get; set; }
        public DbSet<TransazioniConto> TransazioniConto { get; set; }
        public DbSet<Users> UserProfile { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
    }
}