// using Microsoft.AspNetCore.Mvc;

// [ApiController]
// [Route("[controller]")]
// public class CrearTareaController : ControllerBase
// {
//     [HttpPost]
//     [Route("crearTarea")]

//     public IActionResult CrearTarea([FromBody] ParametrosCrearTarea tarea)
//     {
//         Proyecto? proyecto = BuscarJson.BuscarProyecto(tarea.IdProyecto);
//         if (proyecto==null )
//         {
//             return BadRequest(new { error = "No existe un proyecto con ese id", idProyecto = tarea.IdProyecto });
//         }
//         else
//         {
//             Tarea tareaCreada =new Tarea{
//                 IdProyecto=tarea.IdProyecto,
//                 Descripcion=tarea.Descripcion,
//                 FechaVencimiento=tarea.FechaVencimiento,
//             };
//             GuardarJson.GuardarTarea(tareaCreada);
//             return Ok();
//         }
//     }
// }