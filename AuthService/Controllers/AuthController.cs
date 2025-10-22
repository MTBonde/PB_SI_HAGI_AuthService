using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers;

[ApiController]
[Route($"api/{ApiVersion.Route}/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Dummy login - always succeeds with hardcoded tokens
        return Ok(new
        {
            token = "dummy-token-12345",
            refreshToken = "dummy-refresh-67890"
        });
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        // Dummy logout - always succeeds
        return NoContent();
    }
}

public record LoginRequest(string Username, string Password);