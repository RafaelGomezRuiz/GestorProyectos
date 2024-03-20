using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FacadeController : ControllerBase
{
    protected readonly ITareaService _tareaContext;
    public SqliteContext dbSqlite;
    public TareaContext dbSqlServer;
    public FacadeController (ITareaService _tareaContext,SqliteContext dbSqlite,TareaContext dbSqlServer)
    {
        this.dbSqlite=dbSqlite;
        this.dbSqlServer=dbSqlServer;
        this._tareaContext=_tareaContext;
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

    

    

    [HttpPost]
    [Route("crearTarea")]

    public IActionResult CrearTarea([FromBody] ParametrosCrearTarea parametroTarea)
    {
            Tarea tarea = new Tarea
        {
            IdProyecto = parametroTarea.IdProyecto,
            Descripcion = parametroTarea.Descripcion,
            FechaCreacion = DateTime.Now,
            FechaVencimiento = parametroTarea.FechaVencimiento,
            Estado = false,
            TipoDb = parametroTarea.TipoDb
        };

        ITareaService contexto = new Contexto(Factory.CrearConeccion(parametroTarea.TipoDb,dbSqlServer,dbSqlite));
        contexto.InsertarTareaDba(tarea);
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