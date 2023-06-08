using System;
using System.Collections.Generic;
using AucklandPollution.Models;
using Microsoft.EntityFrameworkCore;

namespace AucklandPollution.Data;

public partial class AucklandPollutionContext : DbContext
{
    public AucklandPollutionContext()
    {
    }

    public AucklandPollutionContext(DbContextOptions<AucklandPollutionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AirQuality> AirQualities { get; set; }

    public virtual DbSet<EstuaryQuality> EstuaryQualities { get; set; }

    public virtual DbSet<QwaterQuality> QwaterQualities { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=AucklandPollution; Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AirQuality>(entity =>
        {
            entity.HasKey(e => e.SampleId).HasName("PK__airQuali__3FD4F24BD626F616");

            entity.ToTable("airQuality");

            entity.Property(e => e.SampleId)
                .ValueGeneratedNever()
                .HasColumnName("sampleID");
            entity.Property(e => e.CollectionDate)
                .HasColumnType("date")
                .HasColumnName("collection_date");
            entity.Property(e => e.RegionId).HasColumnName("regionID");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");

            entity.HasOne(d => d.Region).WithMany(p => p.AirQualities)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__airQualit__regio__29572725");
        });

        modelBuilder.Entity<EstuaryQuality>(entity =>
        {
            entity.HasKey(e => e.SampleId).HasName("PK__estuaryQ__3FD4F24B990342A3");

            entity.ToTable("estuaryQuality");

            entity.Property(e => e.SampleId)
                .ValueGeneratedNever()
                .HasColumnName("sampleID");
            entity.Property(e => e.CollectionDate)
                .HasColumnType("date")
                .HasColumnName("collection_date");
            entity.Property(e => e.Indicator)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("indicator");
            entity.Property(e => e.RegionId).HasColumnName("regionID");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Region).WithMany(p => p.EstuaryQualities)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__estuaryQu__regio__2C3393D0");
        });

        modelBuilder.Entity<QwaterQuality>(entity =>
        {
            entity.HasKey(e => e.SampleId).HasName("PK__qwaterQu__3FD4F24B31F654EC");

            entity.ToTable("qwaterQuality");

            entity.Property(e => e.SampleId)
                .ValueGeneratedNever()
                .HasColumnName("sampleID");
            entity.Property(e => e.CollectionDate)
                .HasColumnType("datetime")
                .HasColumnName("collection_date");
            entity.Property(e => e.Indicator)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("indicator");
            entity.Property(e => e.RegionId).HasColumnName("regionID");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Region).WithMany(p => p.QwaterQualities)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__qwaterQua__regio__2F10007B");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__regions__15EA90885D0BEACF");

            entity.ToTable("regions");

            entity.Property(e => e.RegionId).HasColumnName("regionID");
            entity.Property(e => e.RegionName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("region_name");
            entity.Property(e => e.RegionPop).HasColumnName("region_pop");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
