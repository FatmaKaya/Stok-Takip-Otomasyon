﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class stokTakipEntities1 : DbContext
    {
        public stokTakipEntities1()
            : base("name=stokTakipEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Demirbaslar> Demirbaslars { get; set; }
        public virtual DbSet<DemirbasTurleri> DemirbasTurleris { get; set; }
        public virtual DbSet<Departmanlar> Departmanlars { get; set; }
        public virtual DbSet<Fakulteler> Fakultelers { get; set; }
        public virtual DbSet<OdaDemirbasTablosu> OdaDemirbasTablosus { get; set; }
        public virtual DbSet<Odalar> Odalars { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<v_demirbassayisi> v_demirbassayisi { get; set; }
        public virtual DbSet<v_odaDemirbas> v_odaDemirbas { get; set; }
        public virtual DbSet<v_OdaDemirbasListesi> v_OdaDemirbasListesi { get; set; }
        public virtual DbSet<v_OdaDemirbasListesiOdalar> v_OdaDemirbasListesiOdalar { get; set; }
        public virtual DbSet<v_odalaraDemirbasEkleDemirbaslar> v_odalaraDemirbasEkleDemirbaslar { get; set; }
        public virtual DbSet<v_odalaraDemirbasEkleOdalar> v_odalaraDemirbasEkleOdalar { get; set; }
        public virtual DbSet<v_odalardakiDemirbasSayisi> v_odalardakiDemirbasSayisi { get; set; }
        public virtual DbSet<v_odalardanDemirbasKaldir> v_odalardanDemirbasKaldir { get; set; }
        public virtual DbSet<v_odalardanDemirbasKaldirDemirbas> v_odalardanDemirbasKaldirDemirbas { get; set; }
    }
}