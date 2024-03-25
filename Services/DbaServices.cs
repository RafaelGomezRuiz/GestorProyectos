// public class DbaServices : ITarea
// {
//     protected readonly ITarea dbContext;

//     public SqlServerServices(ITarea dbContext)
//     {
//         this.dbContext=dbContext;
//     }

//     public void CrearTarea(Tarea tarea)
//     {
//         dbContext.Tareas.Add(tarea);
//         dbContext.SaveChanges();
//     }

//     public List<Proyecto> GetProyectos()
//     {
//         return dbContext.Proyectos.ToList();
//     }
//     public List<Tarea> GetTareas()
//     {
//         return dbContext.Tareas.ToList();
//     }

//     public bool ProjectExist(int id)
//     {
//         bool proyecto =dbContext.Proyectos.Any(p=>p.Id == id);
//         return proyecto;
//     }
// }