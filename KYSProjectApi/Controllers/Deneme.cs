using Business.Sevices.Interfaces;
using KYSProjectApi.Services.Token;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers;


[ApiController]
[Route("[controller]")]
public class Deneme : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly ICryptographyProcessor _cryptography;

    public Deneme(ITokenService tokenService, ICryptographyProcessor cryptography)
    {
        _tokenService = tokenService;
        _cryptography = cryptography;
    }
    [HttpGet("Generate")]
    public async Task<IActionResult> GetToken()
    => Ok(await _tokenService.GenerateTokenAsync("danismazismail@gmail.com"));

    [HttpPost("Validate")]
    public  IActionResult ValidateToken([FromForm] string token)
    {
        if (token == null || string.IsNullOrWhiteSpace(token))
            return BadRequest("Token is required.");

        bool isValid = _tokenService.ValidateTokenAsync(token);

        if (isValid)
            return Ok(new { Message = "Token is valid." });
        
        return Unauthorized(new { Message = "Token is invalid or expired." });
    }

    [HttpGet("createSifre")]
    public IActionResult CreateSifre()
    {
        var salt = _cryptography.CreateSalt();
        var hash = _cryptography.GenerateHash("123",salt);

        var result = new SaltHash 
        {
            Salt = Convert.ToBase64String(salt),
            Hash = Convert.ToBase64String(hash)
        };



        return Ok(result);
    }
}