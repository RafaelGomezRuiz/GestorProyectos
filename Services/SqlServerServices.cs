public class SqlServerServices
{
    protected readonly SqlServerContext SqlServerContext;

    public SqlServerServices(SqlServerContext SqlServerContext)
    {
        this.SqlServerContext=SqlServerContext;
    }
}