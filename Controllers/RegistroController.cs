using Microsoft.AspNetCore.Mvc;

[ApiController]

[Route("[controller]")]

public class RegistroController : ControllerBase
{
    protected readonly  IUsuarioService _usuarioService;

    public RegistroController (IUsuarioService usuarioService)
    {
         _usuarioService=usuarioService;
    }

    [HttpPost]
    [Route("registro")]

    public IActionResult RegistroUsuario([FromBody] Usuario user)
    {
        return Ok(_usuarioService.PostUser(user));
    }
}