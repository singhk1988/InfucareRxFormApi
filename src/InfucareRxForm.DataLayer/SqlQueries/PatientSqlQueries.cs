namespace InfucareRxForm.DataLayer.SqlQueries;

public static class PatientSqlQueries
{
    /// <summary>
    /// SQL query for retrieving patients.
    /// </summary>
    public const string GetPatients = @"
        SELECT  
            PatientId,
            FirstName,
            LastName,
            Email,
            PhoneNumber,
            MRN,
            CreatedAt, 
            CreatedBy, 
            ModifiedAt, 
            ModifiedBy
       FROM Patient
       WHERE IsDeleted = 0";

}