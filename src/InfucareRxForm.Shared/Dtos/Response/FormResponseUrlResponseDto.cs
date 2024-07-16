namespace InfucareRxForm.Shared.Dtos.Response;

public class FormResponseUrlResponseDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the form response URL.
    /// </summary>
    public long FormResponseUrlId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the patient.
    /// </summary>
    public long PatientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the assessment.
    /// </summary>
    public long AssessmentId { get; set; }

    /// <summary>
    /// Gets or sets the status of the form response.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the medium through which the form response was sent.
    /// </summary>
    public string Medium { get; set; }

    /// <summary>
    /// Gets or sets any comments associated with the form response.
    /// </summary>
    public string Comments { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the form response was sent.
    /// </summary>
    public DateTime SentOn { get; set; }
}