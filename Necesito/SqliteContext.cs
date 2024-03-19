using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext , ITareaService
{
    public DbSet<Tarea> Tareas { get; set; }
    public DbSet<Proyecto> Proyecto { get; set; } // como no estoy creando su estructura en modelcreating por defecto tomara el nombre de la clase para crear la tabla por eso esta singular
    public DbSet<Usuario> Usuarios {get; set;}

    public TareaContext(DbContextOptions options) : base(options){   }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(tarea =>{
            tarea.ToTable("Tarea");
            tarea.HasKey(p=> p.Id);
            tarea.HasOne(p =>p.Proyecto).WithMany(p=>p.Tareas).HasForeignKey(p=>p.IdProyecto);
            tarea.Property(p=>p.Descripcion).IsRequired().HasMaxLength(30);
            tarea.Property(p=>p.Estado).IsRequired().HasMaxLength(5);
            tarea.Property(p=>p.FechaCreacion).IsRequired();
            tarea.Property(p=>p.FechaVencimiento).IsRequired();
            
            tarea.Property(p=>p.TipoDb).IsRequired().HasMaxLength(30);

        });
        
        modelBuilder.Entity<Usuario>(usuario=>{
            usuario.ToTable("Usuario");
            usuario.HasKey(p=>p.Id);
            usuario.Property(p=>p.Name).IsRequired().HasMaxLength(30);
            usuario.Property(p=>p.Email).IsRequired().HasMaxLength(60);
            usuario.Property(p=>p.Password).IsRequired().HasMaxLength(50);
        });
    }
    
    public void InsertarTareaDba(Tarea tarea)
    {
        Tareas.Add(tarea);
        SaveChanges();

    }
    public List<Tarea> ListaTareas()
    {
        return Tareas.ToList();
    }
    public List<Proyecto> ListaProyectos()
    {
        return Proyecto.ToList();
    }
}