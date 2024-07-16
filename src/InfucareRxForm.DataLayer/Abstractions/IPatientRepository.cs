using InfucareRxForm.DataLayer.Entities;

namespace InfucareRxForm.DataLayer.Abstractions;

public interface IPatientRepository
{
    /// <summary>
    /// Retrieves a list of patients from database.
    /// </summary>
    /// <returns>
    /// The task result will be a <see cref="IEnumerable{PatientEntity}"/> object,
    /// if any patient exists, or empty list otherwise.
    /// </returns>
    Task<IEnumerable<PatientEntity>> GetPatients();

}