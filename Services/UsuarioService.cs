// public class UsuarioService : IUsuarioService
// {
//     UsuarioContext dbContext;

//     public UsuarioService(UsuarioContext context)
//     {
//         dbContext = context;
//     }

//     public async Task PostUser(Usuario usuario)
//     {
//         dbContext.Usuarios.Add(usuario);
//         await dbContext.SaveChangesAsync();
//     }

//     // public async Task Login(ParametrosLogin login)
//     // {
//     //     Usuario usuarioLogin=dbContext.Usuarios.FirstOrDefault(c=>c.Email==login.Email);
//     //     if (usuarioLogin!=null)
//     //     {
//     //         usuarioLogin.Password==login.Password;
//     //     }
//     // }
// }