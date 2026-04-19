using Application.CustomerService.Inputs;
using Application.CustomerService.Outputs;

namespace Application.Abstractions.Repositories;

public interface IContactRequestRepository
{
    Task<bool> AddAsync(ContactRequestInput input);
    Task<IReadOnlyList<ContactRequest>> GetAllAsync();
}