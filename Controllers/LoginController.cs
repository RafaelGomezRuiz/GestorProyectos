// using Microsoft.AspNetCore.Mvc;
// [ApiController]

// [Route("[controller]")]

// public class LoginController : ControllerBase
// {
//     [HttpPost]
//     [Route("login")]

//     public IActionResult Login([FromBody] ParametrosLogin? login)
//     {
//         Usuario? usuario=BuscarJson.BuscarUsuario(login.Email);
//         if (usuario == null)
//         {
//             return BadRequest("No existe usuario con ese email");
//         }
//         else
//         {
//             if(usuario.Password==login.Password)
//             {
//                 return Ok();
//             }
//             else
//             {
//                 return BadRequest("Contrasena incorrecta");
//             }
//         }
//     }
// }