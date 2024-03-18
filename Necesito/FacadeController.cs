using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FacadeController : ControllerBase
{
    protected readonly ITareaService _ITareaService;

    public FacadeController (ITareaService _ITareaService)
    {
        this._ITareaService=_ITareaService;
    }



    // [HttpPost]
    // [Route("login")]

    // public IActionResult Login([FromBody] ParametrosLogin login)
    // {
    //     return Ok(_usuarioService.Login(login));
    // }

    [HttpGet]
    [Route("getListaTareas")]

    // public List<Tarea>? listaTareas()
    // {
    //     return ProductosActuales.tareasActuales;
    // }

    [HttpGet]
    [Route("getListaProyectos")]

    // public List<Proyecto>? listaProyectos()
    // {
    //     List<Proyecto>? listaProyectos= ProductosActuales.proyectosActuales;
    //     return listaProyectos;
    // }

    [HttpPost]
    [Route("crearTarea")]

    public IActionResult CrearTarea([FromBody] Tarea tarea)
    {
        return Ok(_ITareaService.InsertarTareaDba(tarea));
    }

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
                GuardarJson.SerializarListaTareas();

                // colaboradorAsignado.Tarea.Add(tarea);
                // GuardarJson.SerializarListaUsuarios();
                
                return Ok();
            }
        }
    }
}