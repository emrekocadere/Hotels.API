using System.Security.Claims;
using Microsoft.AspNetCore.Http;
namespace Hotels.Application.User;


public class UserContext(IHttpContextAccessor httpContextAccessor ) : IUserContext
{
    public CurrentUser GetCurrentUser()
    {
        var user=httpContextAccessor?.HttpContext?.User;
        
        var userId=user.FindFirstValue(ClaimTypes.NameIdentifier);
        var email=user.FindFirstValue(ClaimTypes.Email);
        var role=user.FindFirstValue(ClaimTypes.Role);

        var currentUser = new CurrentUser(userId, email, role);

        return currentUser;

    }
}