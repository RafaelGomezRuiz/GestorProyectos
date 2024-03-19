using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext , ITareaService
{
    public DbSet<Tarea> Tareas { get; set; }
    // public DbSet<Proyecto> Proyecto { get; set; } // como no estoy creando su estructura en modelcreating por defecto tomara el nombre de la clase para crear la tabla por eso esta singular
    // public DbSet<Usuario> Usuarios {get; set;}

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options){   }

    
    public void InsertarTareaDba(Tarea tarea)
    {
        Tareas.Add(tarea);
        SaveChanges();

    }
    public List<Tarea> ListaTareas()
    {
        return null;
    }
    public List<Proyecto> ListaProyectos()
    {
        return null;
    }
}