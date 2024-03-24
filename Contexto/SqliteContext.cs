using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext
{
    public DbSet<Tarea> Tareas {get; set;}
    public DbSet<Proyecto> Proyectos {get; set;}
    public DbSet<Usuario> Usuarios {get; set;}

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) {}
    
}