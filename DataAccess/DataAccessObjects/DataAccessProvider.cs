using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DataAccessObjects;

public class DataAccessProvider
{
    public DataAccessProvider() { }
    private string ConnectionString { get; set; }
    public DataAccessProvider(string connectionString) => ConnectionString = connectionString;
    public void CloseConnection(SqlConnection connection) => connection.Close();
    public SqlParameter CreateParameter(string name, int size, object value, DbType dbType,
                                        ParameterDirection direction = ParameterDirection.Input)
    {
        return new SqlParameter
        {
            ParameterName = name,
            Size = size,
            Value = value,
            DbType = dbType,
            Direction = direction,
        };
    }
    public IDataReader GetDataReader(string commandText, CommandType commandType,
                                    out SqlConnection connection, params SqlParameter[] parameters)
    {
        // CODE HERE
        IDataReader reader = null;
        try
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            reader = command.ExecuteReader();
        } 
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return reader;
    }

    public void Insert(string commandText, CommandType commandType,
                        params SqlParameter[] parameters)
    {
        // CODE HERE
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Update(string commandText, CommandType commandType,
                        params SqlParameter[] parameters)
    {
        // CODE HERE
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Delete(string commandText, CommandType commandType,
                        params SqlParameter[] parameters)
    {
        // CODE HERE
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
