using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.DataDb
{
    public partial class WebeOContext : DbContext
    {
        public WebeOContext()
        {
        }

        public WebeOContext(DbContextOptions<WebeOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriaEmpresa> CategoriaEmpresa { get; set; } = null!;
        public virtual DbSet<Comentario> Comentarios { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Favorito> Favoritos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Puntuacion> Puntuacions { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<ImagenUser> ImagenUser { get; set; } = null!;
        public virtual DbSet<ImagenEmpresa> ImagenEmpresa { get; set; } = null!;
        public virtual DbSet<Categoria> Categoria { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebeO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagenEmpresa>(entity =>
            {
                entity.HasKey(x => x.ImagenEmpresaId);
                entity.ToTable("ImagenEmpresa");
                entity.Property(e => e.EmpresaId)
                    .IsUnicode(false);
                entity.Property(e => e.url)
                   .IsUnicode(false);

            }) ;
            modelBuilder.Entity<ImagenUser>(entity =>
            {
                entity.HasKey(x => x.ImagenUserId);
                entity.ToTable("ImagenUser");
                entity.Property(e => e.UserId)
                    .IsUnicode(false);
                entity.Property(e => e.url)
                   .IsUnicode(false);

            });
            modelBuilder.Entity<CategoriaEmpresa>(entity =>
            {
                entity.HasKey(x => x.CategoriaEmpresaId);
                entity.ToTable("CategoriaEmpresa");

                entity.Property(e => e.NombreCategoria)
                      .IsUnicode(false);
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(x=>x.ComentarioId);

                entity.ToTable("Comentario");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.UsuarioId)
                    .IsUnicode(false);
                entity.Property(e => e.EmpresaId)
                    .IsUnicode(false);
                entity.Property(e => e.ProductoId)
                    .IsUnicode(false);
                entity.Property(e => e.ServicioId)
                    .IsUnicode(false);
                entity.Property(e => e.Abierto)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e=>e.EmpresaId);

                entity.ToTable("Empresa");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Puntuacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.CategoriaId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.ImagenEmpresaIurl)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Favorito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Favorito");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e=>e.ProductoId);

                entity.ToTable("Producto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.EmpresaId)
                    .IsUnicode(false);
                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.ImagenP)
                   .IsUnicode(false);
                entity.Property(e => e.CategoriaId)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Puntuacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Puntuacion");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e=>e.ServicioId);

                entity.ToTable("Servicio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.EmpresaId)
               .IsUnicode(false);
                entity.Property(e => e.TipoServicio)
               .HasMaxLength(50)
               .IsUnicode(false);
                entity.Property(e => e.Descripcion)
               .HasMaxLength(500)
               .IsUnicode(false);
                entity.Property(e => e.ImagenS)
               .HasMaxLength(5000)
               .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(x=>x.UsuarioId);

                entity.ToTable("Usuario");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuarioname)
                    .HasMaxLength(50)
                    .IsUnicode(false);


                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);


                entity.Property(e => e.ImagenUserIurl)
                .IsUnicode(false);

            });
            modelBuilder.Entity<ImagenEmpresa>(entity =>
            {
                entity.HasKey(X=>X.ImagenEmpresaId);

                entity.ToTable("ImagenEmpresa");

                entity.Property(e => e.EmpresaId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<ImagenUser>(entity =>
            {
                entity.HasKey(X => X.ImagenUserId);

                entity.ToTable("ImagenUser");

                entity.Property(e => e.UserId) 
                    .IsUnicode(false);

                entity.Property(e => e.url)                    
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(X => X.CategoriaId);

                entity.ToTable("Categoria");

                entity.Property(e => e.Nombre)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
