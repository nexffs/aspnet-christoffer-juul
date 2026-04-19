using Application.Faq;

namespace Application.Abstractions.Services;

public interface IFaqService
{
    Task<IReadOnlyList<FaqItem>> GetFaqItemsAsync();
}