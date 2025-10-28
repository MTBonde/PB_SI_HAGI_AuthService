using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AuthService.Controllers;

[ApiController]
[Route($"api/{ApiVersion.Route}/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        //Simple in-memory DB containing placeholder users
        MemDB memDb = new MemDB();
        
        if (!memDb.Users.TryGetValue(request.Username, out string? value)) return Unauthorized(); //Login failed
        
        if (request.Password == value)
        {
            Console.WriteLine("Login success!");
            
            //Dummy login - always succeeds with hardcoded tokens
            return Ok(new
            {
                token = GenerateJWToken(request.Username),
                refreshToken = "dummy-refresh-67890" //TODO: Discuss need for refresh vs. invalidation (regular token validation / session login)
            });
        }

        Console.WriteLine("Login failed - Invalid username or password");
        return Unauthorized(); //Login failed
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        // Dummy logout - always succeeds
        //TODO: Invalidate token here?
        return NoContent();
    }

    private string GenerateJWToken()
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345superSecretKey@345")); //TODO: replace with proper secret
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        
        var tokeOptions = new JwtSecurityToken(
            issuer: "https://localhost:5001",
            audience: "https://localhost:5001",
            claims: new List<Claim>(),
            expires: DateTime.Now.AddHours(12), //Long session, just as temp to verify it works. Later add revokation / refresh
            signingCredentials: signinCredentials
        );
        return new JwtSecurityTokenHandler().WriteToken(tokeOptions);
    }

    private string GenerateJWToken(string username)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345superSecretKey@345")); //TODO: replace with proper secret
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var role = username == "admin" ? "admin" : "user"; //Best way of doing this? Probably not...

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, username),
            new(ClaimTypes.Role, role)
        };
        
        var tokeOptions = new JwtSecurityToken(
            issuer: "https://localhost:5001",
            audience: "https://localhost:5001",
            claims: claims,
            expires: DateTime.Now.AddHours(12), //Long session, just as temp to verify it works. Later add revokation / refresh
            signingCredentials: signinCredentials
        );
        
        return new JwtSecurityTokenHandler().WriteToken(tokeOptions);
    }
}

public record LoginRequest(string Username, string Password);


public class MemDB
{
    public readonly Dictionary<string, string> Users = new Dictionary<string, string>();

    public MemDB()
    {
        Users.Add("admin", "admin");
        Users.Add("Thor", "Thor");
        Users.Add("Alex", "Alex");
    }
}