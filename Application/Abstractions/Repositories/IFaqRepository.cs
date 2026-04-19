using Application.Faq;

namespace Application.Abstractions.Repositories;

public interface IFaqRepository
{
    Task<IEnumerable<FaqItem>> GetAllAsync();
}