

public class Factory
{
    public static ITareaService CrearConeccion(string tipoDb,TareaContext SqlServer, SqliteContext Sqlite)
    {
       switch (tipoDb)
        {
            case "SqlServer":
                return SqlServer;
            case "SqLite":
                return Sqlite;
            default:
                throw new ArgumentException("Tipo de base de datos no válido");
        }
    }
}

