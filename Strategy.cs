
public class Strategy : ITarea
{
    private ITarea tarea;

    public Strategy (ITarea tarea) 
    {
        this.tarea=tarea;
    }

    public void  CrearTarea(Tarea tarea)
    {
        tarea.CrearTarea(tarea);
    }
    public List<Tarea> GetTareas()
    {
        return tarea.GetTareas();
    }

    public List<Proyecto> GetProyectos()
    {
        return tarea.GetProyectos();
    }

    public bool ProjectExist(int id)
    {
        return tarea.ProjectExist(id);
    }
}