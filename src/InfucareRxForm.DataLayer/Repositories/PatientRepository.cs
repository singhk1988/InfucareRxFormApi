using System.Data;
using Dapper;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.DataLayer.SqlQueries;

namespace InfucareRxForm.DataLayer.Repositories;

public class PatientRepository(IDapperDbConnection dapperDbConnection) : IPatientRepository
{

    /// <inheritdoc />
    public async Task<IEnumerable<PatientEntity>> GetPatients()
    {
        using IDbConnection dbConnection = dapperDbConnection.CreateConnection();
        return await dbConnection.QueryAsync<PatientEntity>(PatientSqlQueries.GetPatients);
    }
}