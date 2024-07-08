using AutoMapper;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos;

namespace InfucareRxForm.WebAPI.Mappings;

public class PatientResponseMapping : Profile
{
    public PatientResponseMapping()
    {
        CreateMap<PatientEntity, PatientResponseDto>();
    }
}