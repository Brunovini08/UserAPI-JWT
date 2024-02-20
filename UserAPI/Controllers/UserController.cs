using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Data.Dtos;
using UserAPI.Models;
using UserAPI.Services;

namespace UserAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("signup")]
    public async Task<IActionResult> SignupUser([FromBody] CreateUserDto createUserDto)
    {
        await _userService.SignUp(createUserDto);
        return Ok("User signUp");
    }

    [HttpPost("signin")]
    public async Task<IActionResult> SignInUser([FromBody] UserSignInDto userSignInDto)
    {
        var token = await _userService.SignIn(userSignInDto);
        return Ok(token);
    }
}