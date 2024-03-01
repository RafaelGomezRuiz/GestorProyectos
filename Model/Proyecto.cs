public class Proyecto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion{get;set;}
    public DateTime FechaVencimiento{get;set;}
    public List<Usuario>? ColaboradorAsignado{get;set;}

    public Proyecto()
    {
        Estado=true;
        FechaCreacion= DateTime.Now;
        ColaboradorAsignado = new List<Usuario>();
    }
}