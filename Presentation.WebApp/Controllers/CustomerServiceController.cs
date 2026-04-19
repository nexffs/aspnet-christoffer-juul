using Application.Abstractions.Services;
using Application.CustomerService.Inputs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.Models.CustomerService.Forms;

namespace Presentation.WebApp.Controllers
{
    [Route("customer-service")]
    public class CustomerServiceController : Controller
    {
        private readonly IContactRequestService _contactRequestService;

        private readonly IFaqService _faqService;

        public CustomerServiceController(
            IContactRequestService contactRequestService,
            IFaqService faqService)
        {
            _contactRequestService = contactRequestService;
            _faqService = faqService;
        }

        [HttpGet("")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var vm = new CustomerServiceViewModel
            {
                FaqItems = await _faqService.GetFaqItemsAsync(),
                ContactForm = new ContactForm()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CustomerServiceViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.FaqItems = await _faqService.GetFaqItemsAsync();
                return View(vm);
            }

            var input = new ContactRequestInput(
                vm.ContactForm.FirstName,
                vm.ContactForm.LastName,
                vm.ContactForm.Email,
                vm.ContactForm.Phone,
                vm.ContactForm.Message
            );

            var result = await _contactRequestService.CreateContactRequestAsync(input);

            if (!result)
            {
                TempData["ErrorMessage"] = "Unable to send contact request";
                vm.FaqItems = await _faqService.GetFaqItemsAsync();
                return View(vm);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
