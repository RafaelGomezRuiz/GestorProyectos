public class UsuarioService :IUsuarioService
{
    UsuarioContext dbContext;

    public UsuarioService(UsuarioContext context)
    {
        dbContext = context;
    }

    public async Task PostUser(Usuario usuario)
    {
        dbContext.Usuarios.Add(usuario);
        await dbContext.SaveChangesAsync();
    }
}