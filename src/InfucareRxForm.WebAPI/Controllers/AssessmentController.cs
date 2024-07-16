using InfucareRxForm.BusinessLayer.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/assessment")]
public class AssessmentController(IAssessmentService assessmentService) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetPatients()
    {
        return Ok(await assessmentService.GetAssessments());
    }
}
