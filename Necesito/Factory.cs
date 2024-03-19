

public class Factory
{
    public static ITareaService CrearConeccion(string tipoDb)
    {
       switch (tipoDb)
        {
            case "SqlServer":
                return null;
            // case "PostgreSql":
            //     return tareaPostgreSql;
            case "Sqlite":
                return null;
            default:
                throw new ArgumentException("Tipo de base de datos no válido");
        }
    }
}

