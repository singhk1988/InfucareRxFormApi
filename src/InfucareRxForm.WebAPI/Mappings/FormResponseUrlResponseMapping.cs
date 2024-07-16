using AutoMapper;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos.Response;

namespace InfucareRxForm.WebAPI.Mappings;

public class FormResponseUrlResponseMapping : Profile
{
    public FormResponseUrlResponseMapping()
    {
        CreateMap<FormResponseUrlEntity, FormResponseUrlResponseDto>();
    }
}