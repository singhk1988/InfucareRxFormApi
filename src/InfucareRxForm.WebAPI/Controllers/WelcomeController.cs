using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hi, welcome to the InfucareRx backend service.";
    }
}
