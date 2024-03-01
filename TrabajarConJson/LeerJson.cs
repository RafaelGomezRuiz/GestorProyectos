using Newtonsoft.Json;

public class LeerJson
{
    public const string rutaUsarios="Persistencia/Usuarios.json";

    public static List<Usuario>? LeerUsuarios()
    {
        string? usuarios=File.ReadAllText(rutaUsarios);
        List<Usuario>? listaUsuarios=JsonConvert.DeserializeObject<List<Usuario>>(usuarios);
        return listaUsuarios;
    }

}