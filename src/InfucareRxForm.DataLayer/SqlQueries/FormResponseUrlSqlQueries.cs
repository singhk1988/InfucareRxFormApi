namespace InfucareRxForm.DataLayer.SqlQueries;

public static class FormResponseUrlSqlQueries
{
    /// <summary>
    /// SQL query for retrieving form responses.
    /// </summary>
    public const string GetFormResponseUrls = @"
        SELECT  
            FormResponseUrlId,
            PatientId,
            AssessmentId,
            [Status],
            [Medium],
            Comments,
            SentOn
        FROM FormResponseUrl
        WHERE IsDeleted = 0";
}