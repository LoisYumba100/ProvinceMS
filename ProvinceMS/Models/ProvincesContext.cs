using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProvinceMS.Models;

public partial class ProvincesContext : DbContext
{
    public ProvincesContext()
    {
    }

    public ProvincesContext(DbContextOptions<ProvincesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-VPA760F;Initial Catalog=Provinces;User Id=sa;Password=abcd123!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("districts");

            entity.Property(e => e.DistrictId).HasColumnName("districtsId");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("districtName");
            entity.Property(e => e.ProvinceId).HasColumnName("provinceId");

            entity.HasOne(d => d.Province).WithMany(p => p.Districts)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_districts_Provinces");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.Property(e => e.ProvinceId).HasColumnName("provinceId");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("provinceName");
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.Property(e => e.TownId).HasColumnName("townId");
            entity.Property(e => e.DistrictId).HasColumnName("districtId");
            entity.Property(e => e.TownName)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("townName");

            entity.HasOne(d => d.District).WithMany(p => p.Towns)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Towns_districts");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
