using Application.Abstractions.Identity;
using Application.Dtos.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Services;

public class IdentityAuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager) : IAuthService
{
    public async Task<AuthResult> AlreadyExistsAsync(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return AuthResult.Failed();

        var user = await userManager.FindByEmailAsync(email.Trim().ToLowerInvariant());
        return user is null ? AuthResult.Ok() : AuthResult.AlreadyExists();
    }

    public async Task<AuthResult> SignUpUserAsync(string email, string password, string? roleName = null)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return AuthResult.Failed();

        email = email.Trim().ToLowerInvariant();

        var existing = await userManager.FindByEmailAsync(email);
        if (existing is not null)
            return AuthResult.AlreadyExists();

        var user = AppUser.Create(email);

        var createResult = await userManager.CreateAsync(user, password);
        if (!createResult.Succeeded)
            return AuthResult.Failed();

        if (!string.IsNullOrWhiteSpace(roleName))
        {
            if (!await roleManager.RoleExistsAsync(roleName))
                await roleManager.CreateAsync(new IdentityRole(roleName));

            await userManager.AddToRoleAsync(user, roleName);
        }

        await signInManager.SignInAsync(user, isPersistent: false);
        return AuthResult.Ok();
    }

    public async Task<AuthResult> SignInUserAsync(string email, string password, bool rememberMe = false)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return AuthResult.InvalidCredentials();

        var result = await signInManager.PasswordSignInAsync(email, password, rememberMe, false);
        if (result.IsLockedOut)
            return AuthResult.LockedOut();

        if (result.IsNotAllowed)
            return AuthResult.NotAllowed();

        if (result.RequiresTwoFactor)
            return AuthResult.RequireTwoFactorAuth();

        if (!result.Succeeded)
            return AuthResult.Failed();

        return AuthResult.Ok();
    }

    public Task SignOutUserAsync() => signInManager.SignOutAsync();
}