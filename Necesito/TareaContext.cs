using Microsoft.EntityFrameworkCore;

public class TareaContext : DbContext , ITareaService
{
    public DbSet<Tarea> Tarea { get; set; }
    public DbSet<Proyecto> Proyecto { get; set; } // como no estoy creando su estructura en modelcreating por defecto tomara el nombre de la clase para crear la tabla por eso esta singular
    public DbSet<Usuario> Usuarios {get; set;}

    public TareaContext(DbContextOptions<TareaContext> options) : base(options){   }

    
    
    public void InsertarTareaDba(Tarea tarea)
    {
        Tareas.Add(tarea);
        SaveChanges();

    }
}