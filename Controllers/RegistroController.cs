using Microsoft.AspNetCore.Mvc;

[ApiController]

[Route("[controller]")]

public class RegistroController : ControllerBase
{
    [HttpPost]

    public IActionResult RegistroUsuario([FromBody] Usuario user)
    {
        Usuario? usuario = new Usuario
        {
            Name = user.Name,
            Email = user.Email,
            Password= user.Password
        };

        return usuario != null ? Ok() : BadRequest();
        
    }
}