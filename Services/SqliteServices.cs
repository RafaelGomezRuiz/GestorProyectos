public class SqliteService : ITarea
{
    protected SqliteContext SqliteContext;

    public SqliteService(SqliteContext SqliteContext)
    {
        this.SqliteContext=SqliteContext;
    }

    public void  CrearTarea(Tarea tarea)
    {
        SqliteContext.Tareas.Add(tarea);
        SqliteContext.SaveChanges();
    }
    public List<Tarea> GetTareas()
    {
        return SqliteContext.Tareas.ToList();
    }

    public List<Proyecto> GetProyectos()
    {
        return SqliteContext.Proyectos.ToList();
    }

    public bool ProjectExist(int id)
    {
        bool proyecto =SqliteContext.Proyectos.Any(p=>p.Id == id);
        return proyecto;
    }

}

