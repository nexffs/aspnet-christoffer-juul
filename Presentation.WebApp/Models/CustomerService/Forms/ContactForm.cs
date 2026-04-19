using System.ComponentModel.DataAnnotations;

namespace Presentation.WebApp.Models.CustomerService.Forms;

public class ContactForm
{
    [Required(ErrorMessage = "First name is required.")]
    [DataType(DataType.Text)]
    [Display(Name = "First Name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Last name is required.")]
    [DataType(DataType.Text)]
    [Display(Name = "Last Name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Email address is required.")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Please enter a valid email address.")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email Address", Prompt = "username@example.com")]
    public string Email { get; set; } = null!;

    [Phone(ErrorMessage = "Please enter a valid phone number.")]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Phone Number", Prompt = "ex. 070-123 45 67")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "A message is required.")]
    [DataType(DataType.MultilineText)]
    [Display(Name = "Message", Prompt = "Enter your message")]
    public string Message { get; set; } = null!;

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept to save your personal information.")]
    [Display(Name = "I accept that CoreFitness saves my information.")]
    public bool AcceptSavePersonalInformation { get; set; }
}
