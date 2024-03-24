
using Newtonsoft.Json;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

public class Tarea
{
    public int Id {get; set;}
    public int IdProyecto { get; set; }
    public string?  Descripcion { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion{get;set;}
    public DateTime FechaVencimiento{get;set;}
    public virtual Proyecto Proyecto {get;set;}

    public List<Usuario>? ColaboradorAsignado{get;set;}
    public string? TipoDb { get; set; }

    public Tarea()
    {
        Estado=false;
        FechaCreacion= DateTime.Now;
    }
}