public class Usuario
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<Proyecto>? Proyecto {get;set;}
    public List<Tarea>? Tarea { get; set; }

    public Usuario()
    {
        Proyecto = new List<Proyecto>();
        Tarea = new List<Tarea>();
    }
}