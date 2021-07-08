using AppUCA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;

namespace AppUCA.Context
{
    public partial class AppGuiContext : DbContext
    {
       
        public AppGuiContext()
        {
        }
        public AppGuiContext(DbContextOptions<AppGuiContext> options)
           : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlServer("Server = localhost; Database = AppUCADB; Trusted_Connection = True");


        // Model configuration for properties of objects
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Inscription>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Enrollment>()
                .Property(f => f.ID)
                .ValueGeneratedOnAdd();
        }
    }
}
