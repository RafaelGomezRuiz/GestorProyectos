using Newtonsoft.Json;

public class LeerJson
{
    public const string rutaUsarios="Persistencia/Usuarios.json";
    public const string rutaProyectos="Persistencia/Projectos.json";
    public const string rutaTareas="Persistencia/Tareas.json";

    public static List<Usuario>? LeerUsuarios()
    {
        string? usuarios=File.ReadAllText(rutaUsarios);
        List<Usuario>? listaUsuarios=JsonConvert.DeserializeObject<List<Usuario>>(usuarios);
        return listaUsuarios;
    }
    public static List<Proyecto>? LeerProyectos()
    {
        string? proyectos=File.ReadAllText(rutaProyectos);
        List<Proyecto>? listaProyectos=JsonConvert.DeserializeObject<List<Proyecto>>(proyectos);
        return listaProyectos;
    }

    public static List<Tarea> LeerTareas()
    {
        string? tareas=File.ReadAllText(rutaTareas);
        List<Tarea> listaTareas=JsonConvert.DeserializeObject<List<Tarea>>(tareas);
        return listaTareas;
    }

}