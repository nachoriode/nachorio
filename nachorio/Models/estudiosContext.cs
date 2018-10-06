using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace nachorio.Models
{
    public class estudiosContext : DbContext
    {
        public estudiosContext() : base("estudiosContext")
        {

        }
        public DbSet<actitudes> actitudes { get; set; }
        public DbSet<estudios> estudios { get; set; }
        public DbSet<experiencia> experiencia { get; set; }
        public DbSet<taks> taks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
 }