// public class TareaService : ITareaService
// {
//     protected readonly TareaContext TareaContext;

//     public TareaService(TareaContext TareaContext)
//     {
//         this.TareaContext=TareaContext;
//     }

//     public void InsertarTareaDba(Tarea tarea)
//     {
//         ITareaService TareaService;
//         TareaService=new Contexto(Factory.CrearConeccion(tarea.TipoDb,TareaContext));

//         TareaContext.Tareas.Add(tarea);
//         TareaContext.SaveChanges();
//     }
// }