using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UserAPI.Models;

namespace UserAPI.Services;

public class TokenService
{
   public string GenerateToken(User user)
   {
      Claim[] claims = new[]
      {
         new Claim("id", user.Id),
         new Claim("userName", user.UserName),
         new Claim(ClaimTypes.DateOfBirth, user.BirthDate.ToString())
      };
      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("OFISJDFOSIDFJ029348DFSKFJDSLKJF090FDSJ"));

      var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      var token = new JwtSecurityToken(expires: DateTime.Now.AddMinutes(10), claims: claims,
         signingCredentials: signingCredentials);

      return new JwtSecurityTokenHandler().WriteToken(token);
   }
}