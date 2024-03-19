

public class Factory
{
    public static ITareaService CrearConeccion(string TipoDb, TareaContext tareaSqlServer)
    {
       if(TipoDb=="SqlServer") return tareaSqlServer;
       return null;
    }
}

