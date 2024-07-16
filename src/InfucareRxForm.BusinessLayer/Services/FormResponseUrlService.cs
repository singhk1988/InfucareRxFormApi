using AutoMapper;
using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos.Response;

namespace InfucareRxForm.BusinessLayer.Services;

public class FormResponseUrlService(IMapper mapper, IFormResponseUrlRepository formResponseUrlRepository) : IFormResponseUrlService
{
    /// <inheritdoc/>
    public async Task<IEnumerable<FormResponseUrlResponseDto>> GetFormResponseUrls()
    {
        IEnumerable<FormResponseUrlEntity> foundedFormResponseUrls = await formResponseUrlRepository.GetFormResponseUrls();
        return mapper.Map<IEnumerable<FormResponseUrlResponseDto>>(foundedFormResponseUrls);
    }
}