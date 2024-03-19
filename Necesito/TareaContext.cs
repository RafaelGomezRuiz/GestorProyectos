using Microsoft.EntityFrameworkCore;

public class TareaContext : DbContext , ITareaService
{
    public DbSet<Tarea> Tareas { get; set; }

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
    }
    
    public void InsertarTareaDba(Tarea tarea)
    {
        Tareas.Add(tarea);
    }
}