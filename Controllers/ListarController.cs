using Microsoft.AspNetCore.Mvc;
[ApiController]

[Route("[controller]")]

public class ListarController : ControllerBase
{
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
}