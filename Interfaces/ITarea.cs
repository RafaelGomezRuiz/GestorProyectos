public interface ITarea
{
    void CrearTarea(Tarea tarea);
    List<Proyecto> GetProyectos();
    List<Tarea> GetTareas();
    bool ProjectExist(int id);
}