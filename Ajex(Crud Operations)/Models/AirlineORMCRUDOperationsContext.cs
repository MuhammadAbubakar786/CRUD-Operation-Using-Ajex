using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ajex_Crud_Operations_.Models
{
    public partial class AirlineORMCRUDOperationsContext : DbContext
    {
        public AirlineORMCRUDOperationsContext()
        {
        }

        public AirlineORMCRUDOperationsContext(DbContextOptions<AirlineORMCRUDOperationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airline1> Airline1 { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-8RTHSCD;Database=Airline(ORM CRUD Operations);Trusted_Connection=True;User ID=sa; Password=16009065048;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Airline1>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.ArrivalDateTime).HasColumnType("date");

                entity.Property(e => e.DepartialDateTime).HasColumnType("date");

                entity.Property(e => e.Destinantion).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);
            });
        }
    }
}
