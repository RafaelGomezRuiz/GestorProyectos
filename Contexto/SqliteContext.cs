using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext
{
    public DbSet<Tarea> Tareas {get; set;}

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) {}
    
}