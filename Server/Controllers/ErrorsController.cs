using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ErrorsController : ControllerBase
{
    [HttpGet("badrequest")]
    public IActionResult BadRequestError()
    {
        return BadRequest(); //400 Bad Request
    }

    [HttpGet("unauthorized")]
    public IActionResult UnauthorizedError()
    {
        return Unauthorized(); //401 Unauthorized
    }

    [HttpGet("notfound")]
    public IActionResult NotFoundError()
    {
        return NotFound(); //404 Not Found
    }

    [HttpGet("internalerror")]
    public IActionResult InternalServerError()
    {
        return StatusCode(500); //500 Internal Server Error
    }

    [HttpGet("validationerror")]
    public IActionResult ValidationError()
    {
        ModelState.AddModelError("ValidationError", "This is a validation error example.");
        ModelState.AddModelError("AnotherError", "This is another validation error example.");
        return ValidationProblem(); //422 Unprocessable Entity
    }
}