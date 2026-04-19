using Application.Faq;
using Presentation.WebApp.Models.CustomerService.Forms;

public class CustomerServiceViewModel
{
    public IEnumerable<FaqItem> FaqItems { get; set; } = new List<FaqItem>();
    public ContactForm ContactForm { get; set; } = new();
}