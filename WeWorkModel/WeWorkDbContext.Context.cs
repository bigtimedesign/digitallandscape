﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeWorkModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class weWorkEntities : DbContext
    {
        public weWorkEntities()
            : base("name=weWorkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCategory> CompanyCategories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupCategory> GroupCategories { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonCompany> PersonCompanies { get; set; }
        public DbSet<PersonGroup> PersonGroups { get; set; }
        public DbSet<PersonProject> PersonProjects { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}