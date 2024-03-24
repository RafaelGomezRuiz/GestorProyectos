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

    public List<Proyecto> GetProyectos()
    {
        return SqliteContext.Proyectos.ToList();
    }

}

