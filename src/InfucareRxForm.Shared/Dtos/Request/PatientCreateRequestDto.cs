namespace InfucareRxForm.Shared.Dtos.Request;

public class PatientCreateRequestDto
{
    /// <summary>
    /// Gets or sets the first name of the patient.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the patient.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the patient.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the patient.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the medical record number of the patient.
    /// </summary>
    public long MRN { get; set; }
}