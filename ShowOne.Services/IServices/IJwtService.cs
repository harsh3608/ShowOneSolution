using ShowOne.Core.IdentityEntities;
using ShowOne.Core.ResponseModels;
using System.Security.Claims;

namespace ShowOne.Services.IServices
{
    public interface IJwtService
    {
        AuthenticationResponse CreateJwtToken(ApplicationUser user);
        ClaimsPrincipal? GetPrincipalFromJwtToken(string? token);
    }
}
