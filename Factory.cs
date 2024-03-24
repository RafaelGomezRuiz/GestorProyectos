public class Factory
{
    public ITarea  GetContextInstance(string tipoDb, SqliteContext sqliteContext, SqlServerContext sqlServerContext)
    {
        switch (tipoDb)
        {
            case "SqlServer":
                return sqlServerContext;
            case "Sqlite":
                return sqliteContext;
            default: 
                return null;
        }
    }

}