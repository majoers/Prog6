﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelTamagotchi.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelTamagotchiEntities : DbContext
    {
        public HotelTamagotchiEntities()
            : base("name=HotelTamagotchiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Hotelroom> Hotelroom { get; set; }
        public DbSet<Roomtype> Roomtype { get; set; }
        public DbSet<Tamagotchi> Tamagotchi { get; set; }
    }
}