using Application.Abstractions.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.Areas.Authentication.Models;
using Presentation.WebApp.Services;

namespace Presentation.WebApp.Areas.Authentication.Controllers;

[Area("Authentication")]
[Route("registration")]
public class SignUpController(IAuthService authService) : Controller
{
    #region get-started

    [HttpGet("get-started")]
    public IActionResult GetStarted()
    {
        var redirectPath = AuthenticationRedirectService.GetRedirectPathWhenSignedIn(User);
        if (redirectPath is not null)
            return Redirect(redirectPath);

        return View();
    }

    [HttpPost("get-started")]
    [ValidateAntiForgeryToken]
    public IActionResult GetStarted(GetStartedForm form)
    {
        if (!ModelState.IsValid)
            return View(form);

        TempData["SignUpEmail"] = form.Email;

        return RedirectToAction("SetPassword", "SignUp", new { area = "Authentication" });
    }

    #endregion

    #region set-password

    [HttpGet("set-password")]
    public IActionResult SetPassword()
    {
        var redirectPath = AuthenticationRedirectService.GetRedirectPathWhenSignedIn(User);
        if (redirectPath is not null)
            return Redirect(redirectPath);

        return View();
    }

    [HttpPost("set-password")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SetPassword(SetPasswordForm form)
    {
        if (!ModelState.IsValid)
            return View(form);

        var email = TempData["SignUpEmail"]?.ToString();
        if (string.IsNullOrWhiteSpace(email))
        {
            return View(form);
        }

        var result = await authService.SignUpUserAsync(email, form.Password, roleName: "Member");
        if (!result.Succeeded)
        {
            TempData["ErrorMessage"] = "Unable to send create account";
            return View(form);
        }

        return RedirectToAction("AboutMe", "Account", new { area = "Account" });
    }

    #endregion

}
