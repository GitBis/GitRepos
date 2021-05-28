using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Parcial2.Model;

#nullable disable

namespace Parcial2
{
    public partial class SaveContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<securityQuestion> SecurityQuestions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Speciality> Specialties { get; set; }
        
        public SaveContext()
        {
            
        }

        public SaveContext(DbContextOptions<SaveContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=clinicauca;user=root;password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
