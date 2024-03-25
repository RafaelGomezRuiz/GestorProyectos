
public class Strategy : ITarea
{
    private ITarea tarea;

    public Strategy (ITarea _tarea) 
    {
        tarea=_tarea;
    }

    public void  CrearTarea(Tarea _tarea)
    {
        tarea.CrearTarea(_tarea);
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