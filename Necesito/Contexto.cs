public class Contexto : ITareaService
 
{
    private readonly TareaContext _tareaContext;

    public Contexto(TareaContext tareaContext)
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
}