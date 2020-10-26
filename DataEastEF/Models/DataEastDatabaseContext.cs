using System;
using DataEastEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataEastEF
{
    public partial class DataEastDatabaseContext : DbContext
    {
        public DataEastDatabaseContext()
        {
        }

        public DataEastDatabaseContext(DbContextOptions<DataEastDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataEastArcadeList> DataEastArcadeList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Helper.CnnVal("DataEastDatabaseDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataEastArcadeList>(entity =>
            {
                entity.HasKey(e => e.Title);

                entity.ToTable("DataEast_ArcadeList");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50);

                entity.Property(e => e.HardwareType)
                    .HasColumnName("Hardware_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("Release_Date")
                    .HasMaxLength(4);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
