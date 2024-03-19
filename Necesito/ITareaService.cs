public interface ITareaService
{
    void InsertarTareaDba(Tarea tarea);
    List<Tarea> ListaTareas();
    List<Proyecto> ListaProyectos();
}