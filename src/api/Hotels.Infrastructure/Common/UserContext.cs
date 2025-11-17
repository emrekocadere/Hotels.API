using System.Security.Claims;
using Hotels.Application.Common;
using Microsoft.AspNetCore.Http;

namespace Hotels.Infrastructure.Common;

public sealed class UserContext(IHttpContextAccessor httpContextAccessor):IUserContext
{
    public string UserId => httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)!;
}