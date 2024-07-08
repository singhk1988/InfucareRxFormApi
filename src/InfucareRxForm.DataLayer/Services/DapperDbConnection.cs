using System.Data;
using System.Data.SqlClient;
using InfucareRxForm.DataLayer.Abstractions;
using Microsoft.Extensions.Configuration;

namespace InfucareRxForm.DataLayer.Services;

public class DapperDbConnection(IConfiguration configuration) : IDapperDbConnection
{
    private readonly string _connectionString = configuration.GetConnectionString("DefaultConnection");

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}