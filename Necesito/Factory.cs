

public class Factory
{
    public static TareaContext CrearConeccion(string TipoDb, TareaContext tareaSqlServer)
    {
       if(TipoDb=="SqlServer") return tareaSqlServer;
       return null;
    }
}

