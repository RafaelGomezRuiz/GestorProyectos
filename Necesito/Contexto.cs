public class Contexto : ITareaService
 
{
    private readonly TareaContext _tareaContext;

    public Contexto(TareaContext tareaContext)
    {
        _tareaContext = tareaContext;
    }


    public void InsertarTareaDba(Tarea tarea)
    {
        tarea.FechaCreacion = DateTime.Now;
        tarea.Estado = false;
        _tareaContext.InsertarTareaDba(tarea);
        _tareaContext.SaveChanges();
    }
}