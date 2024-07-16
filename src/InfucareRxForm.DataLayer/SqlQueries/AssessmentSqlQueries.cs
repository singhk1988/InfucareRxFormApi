namespace InfucareRxForm.DataLayer.SqlQueries;

public static class AssessmentSqlQueries
{
    /// <summary>
    /// SQL query for retrieving assessments.
    /// </summary>
    public const string GetAssessments = @"
        SELECT  
            AssessmentId,
            FormName,
            Team,
            FormType
        FROM Assessment
        WHERE IsDeleted = 0";


}