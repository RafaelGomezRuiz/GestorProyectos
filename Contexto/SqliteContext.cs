using Microsoft.EntityFrameworkCore;

public class SqliteContext : DbContext, ITarea
{
    public DbSet<Tarea> Tareas {get; set;}
    public DbSet<Proyecto> Proyectos {get; set;}
    public DbSet<Usuario> Usuarios {get; set;}

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(usuario=>{
            usuario.ToTable("Tarea");
            usuario.HasKey(p=>p.Id);
            usuario.HasOne(p=>p.Proyecto).WithMany(p=>p.Tareas).HasForeignKey(p=>p.IdProyecto);
            usuario.Property(p=>p.Estado).IsRequired();
            usuario.Property(p=>p.FechaCreacion).IsRequired();
            usuario.Property(p=>p.FechaVencimiento).IsRequired();
            usuario.Property(p=>p.TipoDb).IsRequired().HasMaxLength(10);
        });
    }

    
    public void  CrearTarea(Tarea tarea)
    {
        Tareas.Add(tarea);
        SaveChanges();
    }
    public List<Tarea> GetTareas()
    {
        return Tareas.ToList();
    }

    public List<Proyecto> GetProyectos()
    {
        return Proyectos.ToList();
    }

    public bool ProjectExist(int id)
    {
        bool proyecto =Proyectos.Any(p=>p.Id == id);
        return proyecto;
    }

}