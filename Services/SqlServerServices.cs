public class SqlServerServices : ITarea
{
    protected readonly SqlServerContext SqlServerContext;

    public SqlServerServices(SqlServerContext SqlServerContext)
    {
        this.SqlServerContext=SqlServerContext;
    }

    public void CrearTarea(Tarea tarea)
    {
        SqlServerContext.Tareas.Add(tarea);
        SqlServerContext.SaveChanges();
    }

    public List<Proyecto> GetProyectos()
    {
        return SqlServerContext.Proyectos.ToList();
    }
}