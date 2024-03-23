// using Microsoft.AspNetCore.Mvc;

// [ApiController]

// [Route("[controller]")]

// public class RegistroController : ControllerBase
// {
//     [HttpPost]
//     [Route("registro")]

//     public IActionResult RegistroUsuario([FromBody] Usuario user)
//     {
//         Usuario? usuario = new Usuario
//         {
//             Name = user.Name,
//             Email = user.Email,
//             Password= user.Password
//         };

//         if (user != null)
//         {
//             GuardarJson.GuardarUsuario(usuario);
//             return Ok();
//         }
//         else
//         {
//             return BadRequest();
//         }
//     }
// }