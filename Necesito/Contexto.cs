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

   
}