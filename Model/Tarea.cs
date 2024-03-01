public class Tarea
{
    public int Id {get; set;}
    public string? IdProyecto { get; set; }
    public string?  Descripcion { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion{get;set;}
    public DateTime FechaVencimiento{get;set;}
    public List<Usuario>? ColaboradorAsignado{get;set;}

    public Tarea()
    {
        Estado=false;
        FechaCreacion= DateTime.Now;
        ColaboradorAsignado = new List<Usuario>();
    }
}