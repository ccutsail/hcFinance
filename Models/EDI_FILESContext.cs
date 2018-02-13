using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hcFinance.Models
{
    public partial class EDI_FILESContext : DbContext
    {
        public virtual DbSet<EdiTable> EdiTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=EDI_FILES;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EdiTable>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK_EDI_TABLE");

                entity.ToTable("EDI_TABLE");

                entity.Property(e => e.AccountNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Carc1).HasColumnName("CARC1");

                entity.Property(e => e.Carc1Desc)
                    .HasColumnName("CARC1_DESC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Carc2).HasColumnName("CARC2");

                entity.Property(e => e.Carc2Desc)
                    .HasColumnName("CARC2_DESC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Carc3).HasColumnName("CARC3");

                entity.Property(e => e.Carc3Desc)
                    .HasColumnName("CARC3_DESC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Carc4).HasColumnName("CARC4");

                entity.Property(e => e.Carc4Desc)
                    .HasColumnName("CARC4_DESC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Carc5).HasColumnName("CARC5");

                entity.Property(e => e.Carc5Desc)
                    .HasColumnName("CARC5_DESC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Pl).HasColumnName("PL");
            });
        }
    }
}