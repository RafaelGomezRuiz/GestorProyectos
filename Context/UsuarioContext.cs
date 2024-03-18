// using Microsoft.EntityFrameworkCore;

// public class UsuarioContext : DbContext
// {
//     public DbSet<Usuario> Usuarios {get; set;}

//     public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options) {}

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<Usuario>(usuario=>{
//             usuario.ToTable("Usuario");
//             usuario.HasKey(p=>p.Id);
//             usuario.Property(p=>p.Name).IsRequired().HasMaxLength(30);
//             usuario.Property(p=>p.Email).IsRequired().HasMaxLength(60);
//             usuario.Property(p=>p.Password).IsRequired().HasMaxLength(50);
//         });
//     }
// }