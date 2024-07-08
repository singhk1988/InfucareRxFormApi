using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InfucareRxForm.WebAPI.Controllers;

[Route("api/form-response-url")]
public class FormResponseUrlController(IFormResponseUrlService formResponseUrlService) : ControllerBase
{
    /// <summary>
    /// Allow to pull all formResponseUrls.
    /// </summary>    
    /// <returns>An IActionResult representing the HTTP response. See <see cref="IEnumerable{FormResponseUrlResponseDto}"/>.</returns>
    [HttpGet]
    [ProducesResponseType(typeof(FormResponseUrlResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(void), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetFormResponseUrls()
    {
        return Ok(await formResponseUrlService.GetFormResponseUrls());
    }
}
