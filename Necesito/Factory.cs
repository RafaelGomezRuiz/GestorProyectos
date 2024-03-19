

public class Factory
{
    public static ITareaService CrearConeccion(string TipoDb)
    {
       switch (tipoDb)
        {
            case "SqlServer":
                return tareaSqlServer;
            // case "PostgreSql":
            //     return tareaPostgreSql;
            case "MySql":
                return tareaMySql;
            default:
                throw new ArgumentException("Tipo de base de datos no válido");
        }
    }
}

