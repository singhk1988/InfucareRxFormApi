using InfucareRxForm.Shared.Dtos;

namespace InfucareRxForm.BusinessLayer.Abstractions;

public interface IAssessmentService
{
    /// <summary>
    /// Retrieves all patients in application.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> encapsulate <see cref="IEnumerable{AssessmentResponseDto}"/> object, containing the list of patient details.</returns>
    Task<IEnumerable<AssessmentResponseDto>> GetAssessments();
}