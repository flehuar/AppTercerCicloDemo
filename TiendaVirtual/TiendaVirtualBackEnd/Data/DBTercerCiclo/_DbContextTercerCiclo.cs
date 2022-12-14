using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.DBTercerCiclo;

public partial class _DbContextTercerCiclo : DbContext
{
    public _DbContextTercerCiclo()
    {
    }

    public _DbContextTercerCiclo(DbContextOptions<_DbContextTercerCiclo> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentaDetalle> VentaDetalles { get; set; }

    public virtual DbSet<VentaEstado> VentaEstados { get; set; }

    public virtual DbSet<VentaTipoDocumento> VentaTipoDocumentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TercerCiclo;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Categoria");

            entity.Property(e => e.Estado).HasComment("0 ==> false | 1 ==> true");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Producto");

            entity.ToTable("Producto", tb => tb.HasComment("Maestra de productos"));

            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.Stock).HasComment("00000,000");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos).HasConstraintName("fk_Producto_Categoria");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venta__3213E83FAF658C53");

            entity.HasOne(d => d.IdVentaEstadoNavigation).WithMany(p => p.Venta).HasConstraintName("FK__Venta__id_venta___32E0915F");

            entity.HasOne(d => d.IdVentaTipoDocumentoNavigation).WithMany(p => p.Venta).HasConstraintName("FK__Venta__id_Venta___31EC6D26");
        });

        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venta_de__3213E83FE783EDCD");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.VentaDetalles).HasConstraintName("FK__Venta_det__id_ca__36B12243");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.VentaDetalles).HasConstraintName("FK__Venta_det__id_pr__37A5467C");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentaDetalles).HasConstraintName("FK__Venta_det__id_Ve__35BCFE0A");

            entity.HasOne(d => d.IdVentaEstadoNavigation).WithMany(p => p.VentaDetalles).HasConstraintName("FK__Venta_det__id_ve__38996AB5");
        });

        modelBuilder.Entity<VentaEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__venta_es__3213E83F2417B591");
        });

        modelBuilder.Entity<VentaTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venta_Ti__3213E83F8DFF0632");

            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
