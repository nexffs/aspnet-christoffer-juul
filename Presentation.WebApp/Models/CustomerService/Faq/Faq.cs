using Presentation.WebApp.Models.CustomerService.Forms;
using Application.Faq;

namespace Presentation.WebApp.Models.CustomerService.Faq;

public class Faq
{
    public IEnumerable<FaqItem> FaqItems { get; set; } = new List<FaqItem>();

    public ContactForm ContactForm { get; set; } = new();
}
