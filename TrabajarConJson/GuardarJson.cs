using Newtonsoft.Json;

public class GuardarJson
{
    public static List<Usuario>? usuariosActuales=LeerJson.LeerUsuarios();
    
    public static void GuardarUsuario(Usuario usuario)
    {
        usuariosActuales.Add(usuario);
        string ? listaUsuario=JsonConvert.SerializeObject(usuariosActuales, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaUsarios, listaUsuario);
    }
    
}