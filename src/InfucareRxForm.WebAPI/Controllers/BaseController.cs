using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

/// <summary>
/// Base controller for common features and functionalities.
/// </summary>
[ApiController]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class BaseController : ControllerBase
{
    // TODO: Add common features and functionalities shared across controllers.
}
