﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineRecritmentSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineRecrutimentModel : DbContext
    {
        public OnlineRecrutimentModel()
            : base("name=OnlineRecrutimentModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Firsttimeuser> Firsttimeusers { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Approved> Approveds { get; set; }
    }
}
