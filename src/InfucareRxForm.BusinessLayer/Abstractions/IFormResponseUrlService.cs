using InfucareRxForm.Shared.Dtos.Response;

namespace InfucareRxForm.BusinessLayer.Abstractions;

public interface IFormResponseUrlService
{
    /// <summary>
    /// Retrieves all formResponseUrls in application.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> encapsulate <see cref="IEnumerable{FormResponseUrlResponseDto}"/> object, containing the list of formResponseUrl details.</returns>
    Task<IEnumerable<FormResponseUrlResponseDto>> GetFormResponseUrls();
}