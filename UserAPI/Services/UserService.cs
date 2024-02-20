using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Data.Dtos;
using UserAPI.Models;

namespace UserAPI.Services;

public class UserService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;
    private TokenService _tokenService;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, TokenService tokenService)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }
    public async Task SignUp(CreateUserDto createUserDto)
    {
        User user = _mapper.Map<User>(createUserDto);
        IdentityResult result = await _userManager.CreateAsync(user, createUserDto.Password);
        if (!result.Succeeded) throw new ApplicationException("Failed to user signup");
    }

    public async Task<string> SignIn(UserSignInDto userSignInDto)
    {
        var result = await _signInManager.PasswordSignInAsync(userSignInDto.UserName, userSignInDto.Password, false, false);
        if (!result.Succeeded) throw new ApplicationException("Failed to user signin");

        var user = _signInManager.UserManager.Users.FirstOrDefault(user =>
            user.UserName == userSignInDto.UserName.ToUpper());

        var token = _tokenService.GenerateToken(user);

        return token;
    }
}