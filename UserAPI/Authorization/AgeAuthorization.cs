using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace UserAPI.Authorization;

public class AgeAuthorization : AuthorizationHandler<MinimalAge>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimalAge requirement)
    {
        var birthDataClaim = context.User.FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);
        if (birthDataClaim is null) return Task.CompletedTask;

        var birthData = Convert.ToDateTime(birthDataClaim.Value);
        var userAge = DateTime.Today.Year - birthData.Year;
        if (birthData > DateTime.Today.AddYears(-userAge))
        {
            userAge--;
        }

        if (userAge >= requirement.Age)
        { 
            context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }
}