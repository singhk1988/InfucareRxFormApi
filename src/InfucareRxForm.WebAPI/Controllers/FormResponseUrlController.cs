using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/form-response-url")]
public class FormResponseUrlController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPatients()
    {
        return Ok();
    }
}
