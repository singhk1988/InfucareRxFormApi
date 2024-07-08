using InfucareRxForm.Shared.Dtos;

namespace InfucareRxForm.BusinessLayer.Abstractions;

public interface IPatientService
{
    /// <summary>
    /// Retrieves all patients in application.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> encapsulate <see cref="IEnumerable{PatientResponseDto}"/> object, containing the list of patient details.</returns>
    Task<IEnumerable<PatientResponseDto>> GetPatients();
}