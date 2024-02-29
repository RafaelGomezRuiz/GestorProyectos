public class BuscarJson
{
    public static Usuario? BuscarUsuario (string email)
    {
        Usuario? usuario=GuardarJson.usuariosActuales.FirstOrDefault(a=>a.Email==email);
        return usuario;
    }
}