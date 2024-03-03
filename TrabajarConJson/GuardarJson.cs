using Newtonsoft.Json;

public class GuardarJson
{
    public static void GuardarUsuario(Usuario usuario)
    {
        ProductosActuales.usuariosActuales.Add(usuario);
        SerializarListaUsuarios();
    
    }
    public static void GuardarTarea(Tarea tarea)
    {
        ProductosActuales.tareasActuales.Add(tarea);
        SerializarListaTareas();
    }
    
    public static void SerializarListaTareas()
    {
        string ? listaTareas=JsonConvert.SerializeObject(ProductosActuales.tareasActuales, Formatting.Indented);
        File.WriteAllText(RutaProductos.rutaTareas, listaTareas);
    }
    
    public static void SerializarListaUsuarios()
    {
        string ? listaUsuario=JsonConvert.SerializeObject(ProductosActuales.usuariosActuales, Formatting.Indented);
        File.WriteAllText(RutaProductos.rutaUsarios, listaUsuario);
    }


    

    
    
}