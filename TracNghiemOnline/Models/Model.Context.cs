﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TracNghiemOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class trac_nghiem_onlineEntities1 : DbContext
    {
        public trac_nghiem_onlineEntities1()
            : base("name=trac_nghiem_onlineEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<quests_of_test> quests_of_test { get; set; }
        public virtual DbSet<score> scores { get; set; }
        public virtual DbSet<speciality> specialities { get; set; }
        public virtual DbSet<status> statuses { get; set; }
        public virtual DbSet<student_test_detail> student_test_detail { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<test> tests { get; set; }
    }
}