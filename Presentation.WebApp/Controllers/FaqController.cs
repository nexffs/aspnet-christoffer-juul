using Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApp.Controllers;

public class FaqController : Controller
{
    private readonly IFaqService _faqService;

    public FaqController(IFaqService faqService)
    {
        _faqService = faqService;
    }

    public async Task<IActionResult> Index()
    {
        var items = await _faqService.GetFaqItemsAsync();
        return View(items);
    }
}