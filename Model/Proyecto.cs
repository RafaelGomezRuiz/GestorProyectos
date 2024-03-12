public class Proyecto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion{get;set;}
    public DateTime FechaVencimiento{get;set;}

    public virtual ICollection<Tarea> tareas {get;set;}//un proyecto tiene varias tareas

    public Proyecto()
    {
        Estado=true;
        FechaCreacion= DateTime.Now;
    }
}