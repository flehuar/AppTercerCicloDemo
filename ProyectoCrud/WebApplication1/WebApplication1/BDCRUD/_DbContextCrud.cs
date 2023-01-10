using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

public partial class _DbContextCrud : DbContext
{
    public _DbContextCrud()
    {
    }

    public _DbContextCrud(DbContextOptions<_DbContextCrud> options)
        : base(options)
    {
    }

    public virtual DbSet<Fruta> Frutas { get; set; }

    public virtual DbSet<FrutaCategoria> FrutaCategorias { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRole> MenuRoles { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CRUD;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fruta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fruta__3213E83F725B0EB1");

            entity.HasOne(d => d.IdFrutaCategoriaNavigation).WithMany(p => p.Fruta).HasConstraintName("FK__fruta__id_fruta___4D94879B");
        });

        modelBuilder.Entity<FrutaCategoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fruta_ca__3213E83F7FA9290D");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu__3213E83F32C878BA");
        });

        modelBuilder.Entity<MenuRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu_rol__3213E83FDBB0023B");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_role__id_me__34C8D9D1");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.MenuRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_role__id_ro__35BCFE0A");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F05897687");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__role__3213E83FE9D9B5A4");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F433E22B0");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK__Usuario__id_role__36B12243");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
