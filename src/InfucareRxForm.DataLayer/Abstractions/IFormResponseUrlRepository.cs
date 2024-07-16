using InfucareRxForm.DataLayer.Entities;

namespace InfucareRxForm.DataLayer.Abstractions;

public interface IFormResponseUrlRepository
{
    /// <summary>
    /// Retrieves a list of formResponseUrls from database.
    /// </summary>
    /// <returns>
    /// The task result will be a <see cref="IEnumerable{FormResponseUrlEntity}"/> object,
    /// if any formResponseUrl exists, or empty list otherwise.
    /// </returns>
    Task<IEnumerable<FormResponseUrlEntity>> GetFormResponseUrls();
}