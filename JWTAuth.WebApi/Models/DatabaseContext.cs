using Microsoft.EntityFrameworkCore;

namespace JWTAuth.WebApi.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado>? Empleado { get; set; }
        public virtual DbSet<Usuario>? UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Usuario");
                entity.Property(e => e.UsuarioID).HasColumnName("Id");
                entity.Property(e => e.Email).HasMaxLength(180).IsUnicode(false);
                entity.Property(e => e.Alias).HasMaxLength(10).IsUnicode(false);
                entity.Property(e => e.Contraseña).HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.RolId).HasColumnName("rol_id").HasMaxLength(1).IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");
                entity.Property(e => e.EmpleadoID).HasColumnName("Id");
                entity.Property(e => e.Genero).HasMaxLength(1).IsUnicode(false);
                entity.Property(e => e.Cedula).HasMaxLength(10).IsUnicode(false);                
                entity.Property(e => e.Nombre).HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.UsuarioID).HasColumnName("usuario_id").HasMaxLength(5).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}