﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteThucPhamSach_VS2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FreshFoodEntities : DbContext
    {
        public FreshFoodEntities()
            : base("name=FreshFoodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<advertis> advertises { get; set; }
        public virtual DbSet<about> abouts { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<@event> events { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<provider> providers { get; set; }
    }
}
