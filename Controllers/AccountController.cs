using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using ChatAppBlazor.Data;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("currentuser")]
    public IActionResult GetCurrentUser()
    {
        var username = User.Identity.Name;
        if (username == null)
        {
            return Unauthorized();
        }

        return Ok(username);
    }
}
