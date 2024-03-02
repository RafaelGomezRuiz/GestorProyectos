using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CrearTareaController : ControllerBase
{
    [HttpPost]
    [Route("crearTarea")]

    public IActionResult CrearTarea([FromBody] ParametrosCrearTarea tarea)
    {
        Proyecto? proyecto = BuscarJson.BuscarProyecto(tarea.IdProyecto);
        Usuario? colaboradorAsignado=BuscarJson.BuscarUsuario(tarea.Email);

        if (proyecto==null || colaboradorAsignado == null)
        {
            return BadRequest();
        }
        else
        {
            Tarea tareaCreada =new Tarea{
                IdProyecto=tarea.IdProyecto,
                Descripcion=tarea.Descripcion,
                FechaVencimiento=tarea.FechaVencimiento,
            };
            tareaCreada.ColaboradorAsignado.Add(colaboradorAsignado);
            GuardarJson.GuardarTarea(tareaCreada);
            return Ok();
        }
    }
}