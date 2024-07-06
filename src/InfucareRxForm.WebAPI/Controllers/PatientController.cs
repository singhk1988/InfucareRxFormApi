using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/patient")]
public class PatientController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPatients()
    {
        return Ok();
    }
}
