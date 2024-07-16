namespace InfucareRxForm.DataLayer.Entities;

/// <summary>
/// Represents an assessment form in the healthcare system.
/// </summary>
public class AssessmentEntity : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the assessment.
    /// </summary>
    public long AssessmentId { get; set; }

    /// <summary>
    /// Gets or sets the name of the form.
    /// </summary>
    public string FormName { get; set; }

    /// <summary>
    /// Gets or sets the team associated with the form.
    /// </summary>
    public string Team { get; set; }

    /// <summary>
    /// Gets or sets the type of the form.
    /// </summary>
    public string FormType { get; set; }
}
