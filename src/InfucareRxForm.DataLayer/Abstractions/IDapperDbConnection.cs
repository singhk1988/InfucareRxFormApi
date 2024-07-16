using System.Data;

namespace InfucareRxForm.DataLayer.Abstractions;

public interface IDapperDbConnection
{
    public IDbConnection CreateConnection();
}
