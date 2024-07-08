using AutoMapper;
using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos;

namespace InfucareRxForm.BusinessLayer.Services;

public class AssessmentService(IMapper mapper, IAssessmentRepository assessmentRepository) : IAssessmentService
{
    /// <inheritdoc/>
    public async Task<IEnumerable<AssessmentResponseDto>> GetAssessments()
    {
        IEnumerable<AssessmentEntity> foundedAssessments = await assessmentRepository.GetAssessments();
        return mapper.Map<IEnumerable<AssessmentResponseDto>>(foundedAssessments);
    }
}