using System.ComponentModel.DataAnnotations;

namespace UserAPI.Data.Dtos;

public class UserSignInDto
{
    [Required] public string UserName { get; set; }
    [Required] public string Password { get; set; }
}