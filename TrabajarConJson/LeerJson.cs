using Newtonsoft.Json;

public class LeerJson
{
    public static List<Usuario>? LeerUsuarios()
    {
        string? usuarios=File.ReadAllText(RutaProductos.rutaUsarios);
        List<Usuario>? listaUsuarios=JsonConvert.DeserializeObject<List<Usuario>>(usuarios);
        return listaUsuarios;
    }
    public static List<Proyecto>? LeerProyectos()
    {
        string? proyectos=File.ReadAllText(RutaProductos.rutaProyectos);
        List<Proyecto>? listaProyectos=JsonConvert.DeserializeObject<List<Proyecto>>(proyectos);
        return listaProyectos;
    }
    public static List<Tarea>? LeerTareas()
    {
        string? tareas=File.ReadAllText(RutaProductos.rutaTareas);
        List<Tarea>? listaTareas=JsonConvert.DeserializeObject<List<Tarea>>(tareas);
        return listaTareas;
    }

}