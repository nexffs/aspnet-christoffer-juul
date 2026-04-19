using Application.Abstractions.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApp.Controllers
{
    [Route("memberships")]
    public class MembershipsController : Controller
    {
        private readonly IFaqService _faqService;

        public MembershipsController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        [HttpGet("")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var vm = new CustomerServiceViewModel
            {
                FaqItems = await _faqService.GetFaqItemsAsync(),
            };

            return View(vm);
        }
    }
}