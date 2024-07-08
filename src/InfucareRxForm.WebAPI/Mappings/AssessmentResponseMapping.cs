using AutoMapper;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos;

namespace InfucareRxForm.WebAPI.Mappings;

public class AssessmentResponseMapping : Profile
{
    public AssessmentResponseMapping()
    {
        CreateMap<AssessmentEntity, AssessmentResponseDto>();
    }
}