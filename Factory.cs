public class Factory
{
    public static ITarea  GetContextInstance(string tipoDb, SqlServerContext SqlServerContext, SqliteContext SqliteContext)
    {
        switch (tipoDb)
        {
            case "SqlServer":
                return  SqlServerContext;
            case "Sqlite":
                return SqliteContext;
            default: 
                return null;
        }
    }

}