using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH3_WKIUQF_2.Models2;

public partial class SzallashelyContext : DbContext
{
    public SzallashelyContext()
    {
    }

    public SzallashelyContext(DbContextOptions<SzallashelyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Foglala> Foglalas { get; set; }

    public virtual DbSet<Szallashely> Szallashelies { get; set; }

    public virtual DbSet<Szoba> Szobas { get; set; }

    public virtual DbSet<Vendeg> Vendegs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=szallashely;User ID=hallgato;Password=Password123;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Foglala>(entity =>
        {
            entity.HasKey(e => e.FoglalasPk);

            entity.Property(e => e.FoglalasPk)
                .ValueGeneratedNever()
                .HasColumnName("FOGLALAS_PK");
            entity.Property(e => e.FelnottSzam).HasColumnName("FELNOTT_SZAM");
            entity.Property(e => e.GyermekSzam).HasColumnName("GYERMEK_SZAM");
            entity.Property(e => e.Meddig)
                .HasColumnType("date")
                .HasColumnName("MEDDIG");
            entity.Property(e => e.Mettol)
                .HasColumnType("date")
                .HasColumnName("METTOL");
            entity.Property(e => e.SzobaFk).HasColumnName("SZOBA_FK");
            entity.Property(e => e.UgyfelFk)
                .HasMaxLength(20)
                .HasColumnName("UGYFEL_FK");

            entity.HasOne(d => d.SzobaFkNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.SzobaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Foglalas_Szoba");

            entity.HasOne(d => d.UgyfelFkNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.UgyfelFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Foglalas_Vendeg");
        });

        modelBuilder.Entity<Szallashely>(entity =>
        {
            entity.HasKey(e => e.SzallasId);

            entity.ToTable("Szallashely");

            entity.Property(e => e.SzallasId)
                .ValueGeneratedNever()
                .HasColumnName("SZALLAS_ID");
            entity.Property(e => e.Cim)
                .HasMaxLength(100)
                .HasColumnName("CIM");
            entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");
            entity.Property(e => e.Hely)
                .HasMaxLength(20)
                .HasColumnName("HELY");
            entity.Property(e => e.RogzIdo)
                .HasColumnType("date")
                .HasColumnName("ROGZ_IDO");
            entity.Property(e => e.Rogzitette)
                .HasMaxLength(20)
                .HasColumnName("ROGZITETTE");
            entity.Property(e => e.SzallasNev)
                .HasMaxLength(50)
                .HasColumnName("SZALLAS_NEV");
            entity.Property(e => e.Tipus)
                .HasMaxLength(50)
                .HasColumnName("TIPUS");
        });

        modelBuilder.Entity<Szoba>(entity =>
        {
            entity.ToTable("Szoba");

            entity.Property(e => e.SzobaId)
                .ValueGeneratedNever()
                .HasColumnName("SZOBA_ID");
            entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");
            entity.Property(e => e.Klimas)
                .HasMaxLength(1)
                .HasColumnName("KLIMAS");
            entity.Property(e => e.Potagy).HasColumnName("POTAGY");
            entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");
            entity.Property(e => e.SzobaSzama)
                .HasMaxLength(20)
                .HasColumnName("SZOBA_SZAMA");

            entity.HasOne(d => d.SzallasFkNavigation).WithMany(p => p.Szobas)
                .HasForeignKey(d => d.SzallasFk)
                .HasConstraintName("FK_Szoba_Szallashely");
        });

        modelBuilder.Entity<Vendeg>(entity =>
        {
            entity.HasKey(e => e.Usernev);

            entity.ToTable("Vendeg");

            entity.Property(e => e.Usernev)
                .HasMaxLength(20)
                .HasColumnName("USERNEV");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nev)
                .HasMaxLength(50)
                .HasColumnName("NEV");
            entity.Property(e => e.SzamlCim)
                .HasMaxLength(100)
                .HasColumnName("SZAML_CIM");
            entity.Property(e => e.SzulDat)
                .HasColumnType("date")
                .HasColumnName("SZUL_DAT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
