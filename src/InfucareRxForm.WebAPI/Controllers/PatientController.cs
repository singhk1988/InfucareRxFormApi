using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/patient")]
public class PatientController(IPatientService patientService) : ControllerBase
{
    /// <summary>
    /// Allow to pull all patients.
    /// </summary>    
    /// <returns>An IActionResult representing the HTTP response. See <see cref="IEnumerable{PatientResponseDto}"/>.</returns>
    [HttpGet]
    [ProducesResponseType(typeof(PatientResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(void), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPatients()
    {
        return Ok(await patientService.GetPatients());
    }
}
