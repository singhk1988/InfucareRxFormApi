using System.Data;
using Dapper;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.DataLayer.SqlQueries;

namespace InfucareRxForm.DataLayer.Repositories;

public class FormResponseUrlRepository(IDapperDbConnection dapperDbConnection) : IFormResponseUrlRepository
{
    /// <inheritdoc />
    public async Task<IEnumerable<FormResponseUrlEntity>> GetFormResponseUrls()
    {
        using IDbConnection dbConnection = dapperDbConnection.CreateConnection();
        return await dbConnection.QueryAsync<FormResponseUrlEntity>(FormResponseUrlSqlQueries.GetFormResponseUrls);
    }
}