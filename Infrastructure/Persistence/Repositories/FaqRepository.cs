using Application.Abstractions.Repositories;
using Application.Faq;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class FaqRepository : IFaqRepository
{
    private readonly PersistenceContext _context;

    public FaqRepository(PersistenceContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FaqItem>> GetAllAsync()
    {
        return await _context.Faqs
            .Select(x => new FaqItem
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            })
            .ToListAsync();
    }
}
