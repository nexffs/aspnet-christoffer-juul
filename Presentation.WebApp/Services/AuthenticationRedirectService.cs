using System.Security.Claims;

namespace Presentation.WebApp.Services;

public static class AuthenticationRedirectService
{
    public static string? GetRedirectPathWhenSignedIn(ClaimsPrincipal user)
    {
        if (user.Identity?.IsAuthenticated != true)
            return null;

        // not currently in use but kept for the future if admins are added

        //if (user.IsInRole("Admin"))
        //    return "/admin";

        if (user.IsInRole("Member"))
            return "/me/about-me";

        return "/";
    }
}