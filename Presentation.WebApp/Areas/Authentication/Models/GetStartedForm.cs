using System.ComponentModel.DataAnnotations;

namespace Presentation.WebApp.Areas.Authentication.Models;

public class GetStartedForm
{
    [Required(ErrorMessage = "Email address is required.")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Please enter a valid email address.")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email Address", Prompt = "username@example.com")]
    public string Email { get; set; } = null!;


    [Range(typeof(bool), "true", "true", ErrorMessage = "Accepting the user terms & conditions is required")]
    public bool TermsAndConditions { get; set; }


    public string? ErrorMessage { get; set; }
}