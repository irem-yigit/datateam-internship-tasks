using Microsoft.AspNetCore.Mvc;
using BookerApp.Models;
using System.Runtime.Versioning;
using System.Data.Common;

namespace BookerApp.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    //Get all users 
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new List<User>
        {
            new User { Id = 1, Username = "iremyigit"}
        };

        return Ok(users);
    }
}




