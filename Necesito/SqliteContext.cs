using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext , ITareaService
{
    public DbSet<Tarea> Tarea { get; set; }

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options){   }

    public void InsertarTareaDba(Tarea tarea)
    {
        Tareas.Add(tarea);
        //SaveChanges();
    }

}