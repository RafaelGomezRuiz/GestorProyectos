public class Contexto : ITareaService
 
{
    ITareaService TareaService;

    public Contexto(ITareaService TareaService)
    {
        this.TareaService=TareaService;
    }

    public void InsertarTareaDba(Tarea tarea)
    {
        tarea.FechaCreacion=DateTime.Now;
        tarea.Estado=false;
        TareaService.InsertarTareaDba(tarea);
    }
}