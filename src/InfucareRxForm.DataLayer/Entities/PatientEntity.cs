namespace InfucareRxForm.DataLayer.Entities;

/// <summary>
/// Represents a patient in the healthcare system.
/// </summary>
public class PatientEntity : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the patient.
    /// </summary>
    public long PatientId { get; set; }

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
