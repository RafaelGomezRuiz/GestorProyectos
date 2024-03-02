using Microsoft.AspNetCore.Mvc;
[ApiController]

[Route("[controller]")]

public class AgregarColaboradoresController : ControllerBase
{   
    [HttpPost]
    [Route("agregarColaborador")]
    public IActionResult AgregarColaborador ([FromBody] ParametrosAgregarColaborador parametros)
    {
        Tarea? tarea = BuscarJson.BuscarTarea(parametros.Id);
        Usuario? colaboradorAsignado=BuscarJson.BuscarUsuario(parametros.Email);
        
        if (colaboradorAsignado==null)
        {
            return BadRequest("Email incorrecto");
        }
        else if (tarea==null)
        {
            return BadRequest("No existe una tarea con ese Id");
        }
        else
        {
            if(BuscarJson.ColaboradorYaEstaAsignado(tarea,colaboradorAsignado))
            {
                return BadRequest("El coralaborador ya ha sido asignado a ese proyecto");
            }
            else
            {
                tarea.ColaboradorAsignado.Add(colaboradorAsignado);
                GuardarJson.GuardarTarea(tarea);
                colaboradorAsignado.Tarea.Add(tarea);
                GuardarJson.GuardarUsuario(colaboradorAsignado);
                return Ok();
            }
        }
    }
}