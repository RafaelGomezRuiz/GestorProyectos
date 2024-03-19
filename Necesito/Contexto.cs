public class Contexto : ITareaService
 
{
    private readonly ITareaService _tareaContext;

    public Contexto(ITareaService tareaContext)
    {
        _tareaContext = tareaContext;
    }


    public void InsertarTareaDba(Tarea tarea)
    {
        _tareaContext.InsertarTareaDba(tarea);
    }

    public List<Tarea> ListaTareas()
    {
        return _tareaContext.ListaTareas();
    }
    public List<Proyecto> ListaProyectos()
    {
        return _tareaContext.ListaProyectos();
    }
}