using InfucareRxForm.DataLayer.Entities;

namespace InfucareRxForm.DataLayer.Abstractions;

public interface IAssessmentRepository
{
    /// <summary>
    /// Retrieves a list of assessments from database.
    /// </summary>
    /// <returns>
    /// The task result will be a <see cref="IEnumerable{AssessmentEntity}"/> object,
    /// if any assessment exists, or empty list otherwise.
    /// </returns>
    Task<IEnumerable<AssessmentEntity>> GetAssessments();

}