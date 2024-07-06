using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/assessment")]
public class AssessmentController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPatients()
    {
        return Ok();
    }
}
