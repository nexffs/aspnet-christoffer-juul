using Application.Abstractions.Repositories;
using Application.Abstractions.Services;

namespace Application.Faq;

public sealed class FaqService : IFaqService
{
    private readonly IFaqRepository _faqRepository;

    public FaqService(IFaqRepository faqRepository)
    {
        _faqRepository = faqRepository;
    }

    public async Task<IReadOnlyList<FaqItem>> GetFaqItemsAsync()
    {
        var items = await _faqRepository.GetAllAsync();
        return items.ToList();
    }
}