public class Usuario
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    // public List<Proyecto>? Proyecto {get;set;}
    public virtual Tarea Tarea { get; set; }

}
