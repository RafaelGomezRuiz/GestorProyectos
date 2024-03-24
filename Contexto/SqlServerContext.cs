using Microsoft.EntityFrameworkCore;

public class SqlServerContext : DbContext
{
    public DbSet<Tarea> Tareas {get; set;}
    public DbSet<Proyecto> Proyectos {get; set;}
    public DbSet<Usuario> Usuarios {get; set;}

    public  SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) {}
}