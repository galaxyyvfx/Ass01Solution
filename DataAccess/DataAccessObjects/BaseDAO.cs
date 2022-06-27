using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DataAccess.DataAccessObjects;

public class BaseDAO
{
    public DataAccessProvider dataAccessProvider { get; set; } = null;
    public SqlConnection connection = null;
    public BaseDAO()
    {
        var connectionString = GetConnectionString();
        dataAccessProvider = new DataAccessProvider(connectionString);
    }
    public String GetConnectionString()
    {
        string connectionString;
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", true, true)
            .Build();
        connectionString = config["ConnectionStrings:MemberDB"];
        return connectionString;
    }
    public void CloseConnection() => dataAccessProvider.CloseConnection(connection);
}
