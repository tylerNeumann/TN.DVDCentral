﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TN.DVDCentral.PL;

public partial class DVDCentralEntities : DbContext
{
    public DVDCentralEntities()
    {
    }

    public DVDCentralEntities(DbContextOptions<DVDCentralEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<tblCustomer> tblCustomers { get; set; }

    public virtual DbSet<tblDirector> tblDirectors { get; set; }

    public virtual DbSet<tblFormat> tblFormats { get; set; }

    public virtual DbSet<tblGenre> tblGenres { get; set; }

    public virtual DbSet<tblMovie> tblMovies { get; set; }

    public virtual DbSet<tblMovieGenre> tblMovieGenres { get; set; }

    public virtual DbSet<tblOrder> tblOrders { get; set; }

    public virtual DbSet<tblOrderItem> tblOrderItems { get; set; }

    public virtual DbSet<tblRating> tblRatings { get; set; }

    public virtual DbSet<tblUser> tblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TN.DVDCentral.DB;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCusto__3214EC074CA8AB7E");

            entity.ToTable("tblCustomer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ZIP)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblDirector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblDirec__3214EC07AE9FA072");

            entity.ToTable("tblDirector");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblForma__3214EC07FE6BDBC2");

            entity.ToTable("tblFormat");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGenre__3214EC077311EE11");

            entity.ToTable("tblGenre");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblMovie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblMovie__3214EC07D6BD1BC8");

            entity.ToTable("tblMovie");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblMovieGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblMovie__3214EC07F81D9FBC");

            entity.ToTable("tblMovieGenre");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<tblOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblOrder__3214EC0733053598");

            entity.ToTable("tblOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.ShipDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblOrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblOrder__3214EC07364B82FC");

            entity.ToTable("tblOrderItem");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<tblRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblRatin__3214EC07622E2E55");

            entity.ToTable("tblRating");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblUser__3214EC076FD90A99");

            entity.ToTable("tblUser");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
