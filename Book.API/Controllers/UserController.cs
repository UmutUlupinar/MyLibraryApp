using Book.Data.Entities;
using Book.Service.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers;

[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class UserController : ControllerBase
{
    private IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    // [AllowAnonymous]
    // [HttpPost("authenticate")]
    // public IActionResult Authenticate([FromBody]User userParam)
    // {
    //     var user = _userService.Authenticate(userParam.KullaniciAdi, userParam.Sifre);
    //     if (user == null)
    //         return BadRequest(new { message = "Kullanici veya şifre hatalı!" });
    //     return Ok(user);
    // }
}