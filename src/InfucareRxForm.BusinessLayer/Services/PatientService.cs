using AutoMapper;
using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Entities;
using InfucareRxForm.Shared.Dtos.Response;

namespace InfucareRxForm.BusinessLayer.Services;

public class PatientService(IMapper mapper, IPatientRepository patientRepository) : IPatientService
{
    /// <inheritdoc/>
    public async Task<IEnumerable<PatientResponseDto>> GetPatients()
    {
        IEnumerable<PatientEntity> foundedPatients = await patientRepository.GetPatients();
        return mapper.Map<IEnumerable<PatientResponseDto>>(foundedPatients);
    }
}