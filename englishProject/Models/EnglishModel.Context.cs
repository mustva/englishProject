﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace englishProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EnglishProjectDBEntities : DbContext
    {
        public EnglishProjectDBEntities()
            : base("name=EnglishProjectDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<levelUserProgress> levelUserProgress { get; set; }
        public virtual DbSet<Box> Box { get; set; }
        public virtual DbSet<IrregularVerb> IrregularVerb { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Word> Word { get; set; }
    }
}
