using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proba_projekt.Models;

public partial class WebshopContext : DbContext
{
    public WebshopContext()
    {
    }

    public WebshopContext(DbContextOptions<WebshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Rendelések> Rendelések { get; set; }

    public virtual DbSet<SzállítóAdatok> SzállítóAdatok { get; set; }

    public virtual DbSet<Szállítók> Szállítók { get; set; }

    public virtual DbSet<Termékek> Termékek { get; set; }

    public virtual DbSet<Vevők> Vevők { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Janka\\source\\repos\\proba_projekt\\proba_projekt\\Database1.mdf;Integrated Security=True; encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rendelések>(entity =>
        {
            entity.HasKey(e => e.RendId).HasName("PK__Rendelés__270FFE569A51DD53");

            entity.Property(e => e.RendId)
                .HasMaxLength(128)
                .HasColumnName("Rend_ID");
            entity.Property(e => e.Időpont).HasColumnType("datetime");
            entity.Property(e => e.TermékFk)
                .HasMaxLength(64)
                .HasColumnName("Termék_FK");
            entity.Property(e => e.VevőFk)
                .HasMaxLength(128)
                .HasColumnName("Vevő_FK");

            entity.HasOne(d => d.TermékFkNavigation).WithMany(p => p.Rendelések)
                .HasForeignKey(d => d.TermékFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rendelése__Termé__3B75D760");

            entity.HasOne(d => d.VevőFkNavigation).WithMany(p => p.Rendelések)
                .HasForeignKey(d => d.VevőFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rendelése__Vevő___3D5E1FD2");
        });

        modelBuilder.Entity<SzállítóAdatok>(entity =>
        {
            entity.HasKey(e => e.SzállítóSk).HasName("PK__Szállító__CAE6C58AE421181C");

            entity.ToTable("Szállító_adatok");

            entity.Property(e => e.SzállítóSk)
                .HasMaxLength(64)
                .HasColumnName("Szállító_SK");
            entity.Property(e => e.Cégnév).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(128);
            entity.Property(e => e.Székhely).HasMaxLength(128);
        });

        modelBuilder.Entity<Szállítók>(entity =>
        {
            entity.HasKey(e => e.SzállításId).HasName("PK__Szállító__C31D728EFC6F3D32");

            entity.Property(e => e.SzállításId)
                .HasMaxLength(128)
                .HasColumnName("Szállítás_ID");
            entity.Property(e => e.EgységárSzállító).HasColumnName("Egységár_szállító");
            entity.Property(e => e.MegrendelésIdőpontja)
                .HasColumnType("datetime")
                .HasColumnName("Megrendelés_időpontja");
            entity.Property(e => e.MennyiségSzállító).HasColumnName("Mennyiség_szállító");
            entity.Property(e => e.SzállítóFk)
                .HasMaxLength(64)
                .HasColumnName("Szállító_FK");
            entity.Property(e => e.TeljesítésIdőpontja)
                .HasColumnType("datetime")
                .HasColumnName("Teljesítés_időpontja");
            entity.Property(e => e.TermékFk)
                .HasMaxLength(64)
                .HasColumnName("Termék_FK");

            entity.HasOne(d => d.SzállítóFkNavigation).WithMany(p => p.Szállítók)
                .HasForeignKey(d => d.SzállítóFk)
                .HasConstraintName("FK__Szállítók__Száll__4222D4EF");

            entity.HasOne(d => d.TermékFkNavigation).WithMany(p => p.Szállítók)
                .HasForeignKey(d => d.TermékFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Szállítók__Termé__4316F928");
        });

        modelBuilder.Entity<Termékek>(entity =>
        {
            entity.HasKey(e => e.TermékSk).HasName("PK__Termékek__D01AFEC9E29EDB4D");

            entity.Property(e => e.TermékSk)
                .HasMaxLength(64)
                .HasColumnName("Termék_SK");
            entity.Property(e => e.Terméknév).HasMaxLength(128);
        });

        modelBuilder.Entity<Vevők>(entity =>
        {
            entity.HasKey(e => e.VevőSk).HasName("PK__Vevők__9F3AAC0A5EF29E3C");

            entity.Property(e => e.VevőSk)
                .HasMaxLength(128)
                .HasColumnName("Vevő_SK");
            entity.Property(e => e.Email).HasMaxLength(128);
            entity.Property(e => e.Login).HasMaxLength(128);
            entity.Property(e => e.Név).HasMaxLength(128);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
