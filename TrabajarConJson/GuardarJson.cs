using Newtonsoft.Json;

public class GuardarJson
{
    public static List<Usuario>? usuariosActuales=LeerJson.LeerUsuarios();
    public static List<Proyecto>? proyectosActuales=LeerJson.LeerProyectos();
    public static List<Tarea>? tareasActuales=LeerJson.LeerTareas();
    
    public static void GuardarUsuario(Usuario usuario)
    {
        usuariosActuales.Add(usuario);
        string ? listaUsuario=JsonConvert.SerializeObject(usuariosActuales, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaUsarios, listaUsuario);
    }
    public static void GuardarTarea(Tarea tarea)
    {
        tareasActuales.Add(tarea);
        string ? listaTareas=JsonConvert.SerializeObject(tareasActuales, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaTareas, listaTareas);
    }

    
    
}