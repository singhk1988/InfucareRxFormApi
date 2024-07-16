using System.Data;
using Dapper;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.DataLayer.SqlQueries;

namespace InfucareRxForm.DataLayer.Repositories;

public class AssessmentRepository(IDapperDbConnection dapperDbConnection) : IAssessmentRepository
{

    /// <inheritdoc />
    public async Task<IEnumerable<AssessmentEntity>> GetAssessments()
    {
        using IDbConnection dbConnection = dapperDbConnection.CreateConnection();
        return await dbConnection.QueryAsync<AssessmentEntity>(AssessmentSqlQueries.GetAssessments);
    }
}