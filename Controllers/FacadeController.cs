using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FacadeController : ControllerBase
{

    protected readonly ITarea sqliteService;

    public FacadeController(ITarea sqliteService)
    {
        this.sqliteService=sqliteService;
    }

    [HttpPost]
    [Route("login")]

    public IActionResult Login([FromBody] ParametrosLogin? login)
    {
        Usuario? usuario=BuscarJson.BuscarUsuario(login.Email);
        if (usuario == null)
        {
            return BadRequest("No existe usuario con ese email");
        }
        else
        {
            if(usuario.Password==login.Password)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Contrasena incorrecta");
            }
        }
    }

    [HttpGet]
    [Route("getListaTareas")]

    public List<Tarea>? listaTareas()
    {
        return ProductosActuales.tareasActuales;
    }

    [HttpGet]
    [Route("getListaProyectos")]

    public List<Proyecto>? listaProyectos()
    {
        List<Proyecto>? listaProyectos= ProductosActuales.proyectosActuales;
        return listaProyectos;
    }

    [HttpPost]
    [Route("crearTarea")]

    public IActionResult CrearTarea([FromBody] ParametrosCrearTarea parametroTarea)
    {
        // Proyecto proyecto=sqliteService.SqliteContext.Proyectos.FirstOrDefault(p=>p.Id==parametroTarea.IdProyecto);

        // if(proyecto==null){
        //     return BadRequest(new { error = "No existe un proyecto con ese id", parametroTarea.IdProyecto });
        // }
         Tarea tarea = new Tarea
        {
            IdProyecto = parametroTarea.IdProyecto,
            Descripcion = parametroTarea.Descripcion,
            FechaVencimiento = parametroTarea.FechaVencimiento,
            TipoDb = parametroTarea.TipoDb
        };
        
        sqliteService.CrearTarea(tarea);
        return Ok();
        
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